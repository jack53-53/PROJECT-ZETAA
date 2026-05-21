using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    private Vector2 Movement;
    private Vector2 Olhamento;
    private Rigidbody rb;
    public float Vel;
    private GameObject gb;
    public float Sens;
    private float xRotation;
    public Transform Camera;
    private bool Interagiu;
    public int MaxInteracDistance;
    private LayerMask LayerInteractables;
    public bool Conversando;
    private float Mvel;
    private float Msens;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI NomeFalador;
    private FaladorScript fs;
    private float CoolDownConversa;
    public float MCoolDownConversa;
    private GameObject go;
    private DATASCRIPT ds;
    private float Volume;
    private bool Inventario;
    private bool Pulou;
    public Image img;
    public TextMeshProUGUI TextoDicas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        go = GameObject.FindGameObjectWithTag("DATA");
        if (go != null)
        {
            ds = go.GetComponent<DATASCRIPT>();
            Sens = ds.SensSaved;
            Volume = ds.SoundSaved;
        }
        rb = GetComponent<Rigidbody>();
        LayerInteractables = LayerMask.GetMask("Interagivel");
        //LayerAtiravel = LayerMask.GetMask("Atiravel");
        Mvel = Vel;
        Msens = Sens;
        //DicaTxt.text = "";
        if(SceneManager.GetActiveScene().name == "Introducao")
        {
            Interagiu = true;
        }
    }

    private void FixedUpdate()
    {
        if (Pulou)
        {
            Pulou = false;
            Inventario = !Inventario;
        }
        if (Inventario) 
        {
            img.enabled = true;
            TextoDicas.text = ds.TextoDicas;
            rb.linearVelocity = Vector3.zero;
        }
        else if (!Inventario)
        {
            img.enabled = false;
            TextoDicas.text = "";
        }
        if (Conversando)
        {
            Vel = 0;
            Sens = 0;
            fs = gb.GetComponent<FaladorScript>();
            txt.text = fs.ConversaDialogo;
            NomeFalador.text = fs.NomeFalador;
            //Debug.Log("estagio da conversa: "+fs.ConversaEstagio);
            if (Interagiu)
            {
                fs.ConversaEstagio++;
                Interagiu = false;
            }
            if (fs.FimConversa == fs.ConversaEstagio)
            {
                Conversando = false;
                txt.text = "";
                NomeFalador.text = "";
            }
        }
        else //pode dar muito errado
        {
            Vel = Mvel;
            Sens = Msens;
        }

        if (Interagiu && !Conversando)
        {
            RaycastHit Atingido;
            Interagiu = false;
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Atingido, MaxInteracDistance, LayerInteractables);
            if (Atingido.transform != null)
            {
                gb = Atingido.transform.gameObject;//so vai acertar os que estao na layer certa 
                Conversando = true;
            }
        }

        Vector3 moveDirection = transform.forward * Movement.y + transform.right * Movement.x;
        rb.linearVelocity = new Vector3(moveDirection.x * Vel, rb.linearVelocity.y, moveDirection.z * Vel);

        xRotation -= Olhamento.y * Sens;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        Camera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        transform.Rotate((Vector3.up * Olhamento.x) * Sens);

        CoolDownConversa -= Time.fixedDeltaTime;
    }
    void OnMove(InputValue e)
    {
        Movement = e.Get<Vector2>();
    }

    void OnLook(InputValue e)
    {
        Olhamento = e.Get<Vector2>();
    }

    void OnInteract(InputValue e)
    {
        if (CoolDownConversa <= 0 && e.isPressed)
        {
            Interagiu = true;
            CoolDownConversa = MCoolDownConversa;
        }
    }

    void OnJump(InputValue e)
    {
        if (e.isPressed)
        {
            Pulou = true;
        }
    }

    //void OnFire(InputValue e)
    //{
    //    if (CoolDownConversa <= 0 && e.isPressed)
    //    {
    //        Atirou = true;
    //        CoolDownConversa = MCoolDownConversa;
    //    }
    //}
}
