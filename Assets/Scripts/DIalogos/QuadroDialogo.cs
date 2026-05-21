using UnityEngine;
using UnityEngine.SceneManagement;

public class QuadroDialogo : FaladorScript
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
                NomeFalador = "Quadro: ";
                ConversaDialogo = "O Mr.Man reclamou das manchas “verdes” que adicionaram nas pinturas.";
                N = true;
                break;
        }
        if (N && a == 0)
        {
            a = 1;
            ds.TextoDicas += "\nQuadros danificados com spray.";
        }

    }
}
