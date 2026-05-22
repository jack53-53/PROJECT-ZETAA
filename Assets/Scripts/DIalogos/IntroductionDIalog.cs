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
                ConversaDialogo = "Sou do Detective S.C. (small claims) e foi-me atribuído um novo caso: A morte de wooble, o gatinho laranja da Lady Donna";
                break;
            case 1:
                NomeFalador = "";
                ConversaDialogo = "Recentemente descobriu-se uma nova tecnologia em que é possível navegar pelas memórias";
                break;
            case 2:
                NomeFalador = "";
                ConversaDialogo = "desenvolvida por engenheiros forenses para investigar crimes através de circunstantes. ";
                break;
            case 3:
                NomeFalador = "";
                ConversaDialogo = "Vou me reunir com 4 testemunhas e investigar as suas memórias.";
                break;
            case 4:
                NomeFalador = "";
                ConversaDialogo = "Coleto pistas e aponto tudo no meu caderno.";
                break;
            case 5:
                NomeFalador = "";
                ConversaDialogo = "Posso sempre verificar o meu caderno quando pressiono o espaço.";
                break;
            case 6:
                NomeFalador = "";
                ConversaDialogo = "Nota da autora: O vermelho não é sangue, apenas tinta em spray";
                break;
            case 7:
                SceneManager.LoadScene("Nivel1");
                break;
        }
    }
}
