using UnityEngine;
using UnityEngine.SceneManagement;

public class Poltrona : FaladorScript
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
                NomeFalador = "Poltrona: ";
                ConversaDialogo = "Confortável… Não sei se chegam a usar isto… Agora muito menos, já que está completamente estragada com tinta.";
                N = true;
                break;
        }
        if (N && a == 0)
        {
            a = 1;
            ds.TextoDicas += "\nPoltrona com um cheiro muito forte";
        }

    }
}
