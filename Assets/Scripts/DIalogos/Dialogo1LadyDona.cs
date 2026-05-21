using UnityEngine;
using UnityEngine.SceneManagement;

public class Dialogo1LadyDona : FaladorScript
{
    private void Update()
    {
        switch (ConversaEstagio)
        {
            case 0:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "Então Lady Donna… como é que o gato saiu de casa?";
                break;
            case 1:
                NomeFalador = "Lady Donna";
                ConversaDialogo = "Oh, pela porta filho.";
                break;
            case 2:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "E quem abriu a porta?";
                break;
            case 3:
                NomeFalador = "Lady Donna: ";
                ConversaDialogo = "Oh, devo ter sido eu. Mas não me lembro de ver o gato a fugir, eu tava a dar-lhe comidinha quando me chamaram.";
                break;
            case 4:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "Impossível. O gato morreu.";
                break;
            case 5:
                NomeFalador = "Lady Donna:";
                ConversaDialogo = "Oh o gato morreu? Então quem é aquele a comer?";
                break;
            case 6:
                SceneManager.LoadScene("Nivel1 1");
                break;
        }
    }
}
