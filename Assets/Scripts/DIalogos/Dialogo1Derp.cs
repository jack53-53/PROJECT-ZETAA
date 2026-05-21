using UnityEngine;
using UnityEngine.SceneManagement;

public class Dialogo1Derp : FaladorScript
{
    private void Update()
    {
        switch (ConversaEstagio)
        {
            case 0:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "O que fazias a pintar as paredes do prédio. Vandalismo é crime!";
                break;
            case 1:
                NomeFalador = "Derp:";
                ConversaDialogo = "São feias e sem personalidade… como tu.";
                break;
            case 2:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "Como se tivesses feito uma obra prima! Tava horroroso.";
                break;
            case 3:
                NomeFalador = "Derp:";
                ConversaDialogo = "Faz melhor então…Eu só não sabia que a tinta tinha um cheiro tão forte";
                break;
            case 4:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "Que spray é esse?";
                break;
            case 5:
                NomeFalador = "Derp: ";
                ConversaDialogo = "É novo. Super aderente… acho que é um pouco tóxico… mas não pra pessoas.\r\n";
                break;
            case 6:
                NomeFalador = "Detective S.C.:";
                ConversaDialogo = "E porque usaste sabendo disso?";
                break;
            case 7:
                NomeFalador = "Derp: ";
                ConversaDialogo = "Porque não?";
                break;
            case 8:
                SceneManager.LoadScene("Nivel3 1");
                break;
        }
    }
}
