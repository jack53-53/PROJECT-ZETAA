using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        LayerInteractables = LayerMask.GetMask("Interagivel");
        Mvel = Vel;
        Msens = Sens;
    }

    private void FixedUpdate()
    {
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
            if(fs.FimConversa == fs.ConversaEstagio)
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
            if(Atingido.transform != null)
            {
                gb = Atingido.transform.gameObject;//so vai acertar os que estao na layer certa 
                Conversando = true;
            }
        }

        Vector3 moveDirection = transform.forward * Movement.y + transform.right * Movement.x;
        rb.linearVelocity = new Vector3(moveDirection.x * Vel,rb.linearVelocity.y,moveDirection.z * Vel);

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
        if(CoolDownConversa <= 0 && e.isPressed)
        {
            Interagiu = true;
            CoolDownConversa = MCoolDownConversa;
        }
    }
}
