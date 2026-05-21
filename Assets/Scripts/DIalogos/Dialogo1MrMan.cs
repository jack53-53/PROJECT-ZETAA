using UnityEngine;
using UnityEngine.SceneManagement;

public class Dialogo1MrMan : FaladorScript
{
    private void Update()
    {
        switch (ConversaEstagio)
        {
            case 0:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "Onde é que o senhor ia tão apressado?";
                break;
            case 1:
                NomeFalador = "Mr.Man:";
                ConversaDialogo = "Reunião importante.";
                break;
            case 2:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "Com o que trabalha?";
                break;
            case 3:
                NomeFalador = "Mr.Man: ";
                ConversaDialogo = "Negócios";
                break;
            case 4:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "E por acaso reparou no vermelho na sua maleta?";
                break;
            case 5:
                NomeFalador = "Mr.Man: ";
                ConversaDialogo = "Vermelho? Eu só vi verde. Como a minha gravata.";
                break;
            case 6:
                NomeFalador = "Detective S.C.:";
                ConversaDialogo = "Uh...";
                break;
            case 7:
                NomeFalador = "Mr.Man: ";
                ConversaDialogo = "Já acabou? Tenho negócios para tratar.";
                break;
            case 8:
                SceneManager.LoadScene("Nivel4 1");
                break;
        }
    }
}
