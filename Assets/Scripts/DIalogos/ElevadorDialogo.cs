using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevadorDialogo : FaladorScript
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
                NomeFalador = "Elevador: ";
                ConversaDialogo = "Porque é que existe um elevador se só têm o resto de chão e primeiro andar?";
                N = true;
                break;
        }
        if (N && a == 0)
        {
            a = 1;
            ds.TextoDicas += "\nElevador praticamente ínutil\nÉ daltónico e não sabe ";
        }

    }
}
