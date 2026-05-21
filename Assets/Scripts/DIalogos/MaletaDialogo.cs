using UnityEngine;
using UnityEngine.SceneManagement;

public class MaletaDialogo : FaladorScript
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
                NomeFalador = "Maleta: ";
                ConversaDialogo = "Parece ser do Mr. Man. Esta mancha vermelha deve ser do gato… tem até os bigodes.";
                N = true;
                break;
        }
        if (N && a == 0)
        {
            a = 1;
            ds.TextoDicas += "\nMaleta com marca do rosto de wooble";
        }

    }
}
