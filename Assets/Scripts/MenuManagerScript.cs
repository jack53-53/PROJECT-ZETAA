using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    public int Opcao;
    private bool Escolheu;
    private Vector2 Mov;
    public int Limite;
    public GameObject DATA;
    private GameObject d;

    private void Start()
    {
        d = GameObject.FindGameObjectWithTag("DATA");
        if (d == null)
        {
            Instantiate(DATA);
        }
    }
    private void Update()
    {
        if (Escolheu)
        {
            if (Opcao == 0)
            {
                SceneManager.LoadScene("Introducao");
            }
            else if (Opcao == 1)
            {
                SceneManager.LoadScene("Settings");
            }
        }
        if (Mov.y < 0) //cima
        {
            if ((Opcao + 1 ) != Limite)
            {
                Opcao++;
            }
        }
        else if (Mov.y > 0)
        {
            if (Opcao - 1 != -1)
            {
                Opcao--;
            }
        }
    }

    void OnNavigate(InputValue e)
    {
        Mov = e.Get<Vector2>();
    }

    void OnSubmit(InputValue e)
    {
        Escolheu = true;
    }
}
