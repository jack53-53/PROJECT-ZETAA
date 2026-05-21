using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalDialogo : FaladorScript
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
                NomeFalador = "Porta: ";
                ConversaDialogo = "Casa da Lady Donna, foi aqui que o gato fugiu.";
                N = true;
                break;
        }
        if (N && a == 0)
        {
            a = 1;
            ds.TextoDicas += "\nPorta aberta de fuga para o gato";
        }

    }
}
