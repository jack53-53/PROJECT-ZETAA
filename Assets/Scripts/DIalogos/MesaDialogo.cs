using UnityEngine;
using UnityEngine.SceneManagement;

public class MesaDialogo : FaladorScript
{
    private GameObject go;
    private DATASCRIPT ds;
    private bool N;
    private int a;

    private void Start()
    {
        go = GameObject.FindGameObjectWithTag("DATA");
        ds = go.GetComponent<DATASCRIPT>();
    }
    private void Update()
    {
        switch (ConversaEstagio)
        {
            case 0:
                NomeFalador = "Mesa: ";
                ConversaDialogo = "O pobre coitado foi contra a mesa também, tem uma perna vermelha.";
                N = true;
                break;
        }
        if (N && a == 0)
        {
            a = 1;
            ds.TextoDicas += "\nMesa danificada\nA senhora precisa de ir ao oftalmologista";
        }

    }
}
