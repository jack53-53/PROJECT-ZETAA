using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroductionDIalog : FaladorScript
{

    // Update is called once per frame
    void Update()
    {
        switch (ConversaEstagio)
        {
            case 0:
                NomeFalador = "";
                ConversaDialogo = "to aqui vendo pq o gato morreu";
                break;
            case 1:
                NomeFalador = "";
                ConversaDialogo = "tenho que ir interrogar os outros entrando dentro das memorias deles";
                break;
            case 2:
                SceneManager.LoadScene("Nivel1");
                break;
        }
    }
}
