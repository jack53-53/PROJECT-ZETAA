using UnityEngine;
using UnityEngine.SceneManagement;

public class LataDialogo : FaladorScript
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
                NomeFalador = "Spray de tinta: ";
                ConversaDialogo = "O cheiro é extremamente desconfortável, tou a sentir-me tonto.";
                N = true;
                break;
        }
        if (N && a == 0)
        {
            a = 1;
            ds.TextoDicas += "\nLata de spray ilegal";
        }

    }
}
