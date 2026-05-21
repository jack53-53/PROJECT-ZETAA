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
                ConversaDialogo = "Sou do Detective S.C. (small claims) e foi-me atribuído um novo caso: A morte de Wooble, o gatinho laranja da Lady Donna.";
                break;
            case 1:
                NomeFalador = "";
                ConversaDialogo = "Recentemente descobriu-se uma nova tecnologia em que é possível navegar pelas memórias, desenvolvida por engenheiros forenses para investigar crimes através de circunstantes. Vou me reunir com 4 testemunhas e investigar as suas memórias.";
                break;
            case 2:
                SceneManager.LoadScene("Nivel1");
                break;
        }
    }
}
