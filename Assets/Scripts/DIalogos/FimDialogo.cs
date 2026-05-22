using UnityEngine;
using UnityEngine.SceneManagement;

public class FimDialogo : FaladorScript
{
    private void Update()
    {
        switch (ConversaEstagio)
        {
            case 0:
                NomeFalador = "";
                ConversaDialogo = "Depois de reúnir as pistas percebi tudo...";
                break;
            case 1:
                ConversaDialogo = "Com o descuido de Lady Donna o gato fugiu";
                break;
            case 2:
                ConversaDialogo = "Com a pressa de Crystal o gato assustou-se";
                break;
            case 3:
                ConversaDialogo = "Com o spray tóxico do derp o gato ficou tonto";
                break;
            case 4:
                ConversaDialogo = "E ao bater na maleta de Mr Man, atordoado, foi contra um móvel";
                break;
            case 5:
                ConversaDialogo = "Pouco tempo depois o tijolo caiu de dentro do vaso e bateu-lhe na cabeça";
                break;
            case 6:
                ConversaDialogo = "EUREKA! SÃO TODOS CULPADOS.";
                break;
            case 7:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
        }
    }
}
