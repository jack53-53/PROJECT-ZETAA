using UnityEngine;
using UnityEngine.SceneManagement;

public class VasoDialogo : FaladorScript
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
                NomeFalador = "Vaso: ";
                ConversaDialogo = "O tijolo provavelmente caiu daqui de dentro.";
                N = true;
                break;
        }
        if (N && a == 0)
        {
            a = 1;
            ds.TextoDicas += "\nVaso parecia esconder algo";
        }

    }
}
