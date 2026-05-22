using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class FaladorScript : MonoBehaviour
{
    //SUPOSTO SER A CLASSE QUE OS SCRIPTS HERDAM PARA SER CONVERSAVEIS, DAI A CONVERSA VAI ESTAR LA DENTRO
    public int ConversaEstagio;
    public string ConversaDialogo;
    public int FimConversa;
    public string NomeFalador;
    private PlayerScript ps;
    private GameObject p;
    public bool Tocou;

    // public GameObject Pai;

    // void Start()
    // {
    //     // Pai = this.GameObject();
    //     p = GameObject.FindGameObjectWithTag("Player");
    //     ps = p.GetComponent<PlayerScript>();
    // }

    // public void CarregarCena(string NomeCena)
    // {
    //     ps.LoadScene(NomeCena);
    // }
}
