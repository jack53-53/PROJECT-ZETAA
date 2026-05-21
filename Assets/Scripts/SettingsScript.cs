using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    public int Opcao;
    private bool Escolheu;
    private Vector2 Mov;
    public int Limite;
    private float Volume;
    private float Sens; //vou ter que criar um gameobject permanente que vai passar esse valor pro playerscript dps
    public float Cooldown;
    private float MCooldown;
    public TextMeshProUGUI Opcao1;
    public TextMeshProUGUI Opcao2;
    public TextMeshProUGUI Opcao3;
    public GameObject DATA;
    private GameObject go;
    private DATASCRIPT ds;

    private void Start()
    {
        MCooldown = Cooldown;
        Instantiate(DATA);
        go = GameObject.FindGameObjectWithTag("DATA");
        ds = go.GetComponent<DATASCRIPT>();
    }

    private void Update()
    {
        ds.SensSaved = Sens;
        ds.SoundSaved = Volume;
        Opcao1.text = "Fullscreen: " + Screen.fullScreen;
        Opcao2.text = "Volume: " + Volume;
        Opcao3.text = "Sensitivity: " + Math.Round(Sens, 1);

        if (Cooldown <= 0)
        {
        if (Escolheu)
        {
            if (Opcao == 0)
            {
                Screen.fullScreen = !Screen.fullScreen;
                Escolheu = false;
                    Cooldown = MCooldown;
            }
        }
        if (Mov.y > 0) //cima
        {
            if ((Opcao + 1) != Limite)
            {
                Opcao++;
                    Cooldown = MCooldown;
                }
        }
        else if (Mov.y < 0)
        {
            if (Opcao - 1 != -1)
            {
                Opcao--;
                    Cooldown = MCooldown;
                }
        }
        if(Mov.x < 0 && Opcao == 1)
        {
            Volume--;
                Cooldown = MCooldown;
            }
        else if (Mov.x > 0 && Opcao == 1)
        {
            Volume++;
                Cooldown = MCooldown;
            }
        if (Mov.x < 0 && Opcao == 2) //SPAGUETTI
        {
            Sens-=0.1f;
                Cooldown = MCooldown;
            }
        else if (Mov.x > 0 && Opcao == 2)
        {
            Sens+= 0.1f;
                Cooldown = MCooldown;
            }
        }
        Cooldown -= Time.fixedDeltaTime;

    }

    void OnNavigate(InputValue e)
    {
        Mov = e.Get<Vector2>();
    }

    void OnSubmit(InputValue e)
    {
        if (Cooldown <= 0 && e.isPressed)
        {
            Escolheu = true;
        }
    }

    void OnRightClick(InputValue e)
    {
        SceneManager.LoadScene("Menu");
    }
}
