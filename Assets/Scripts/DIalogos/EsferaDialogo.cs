using UnityEngine;

public class EsferaDialogo : FaladorScript
{
    private void Update()
    {
        switch (ConversaEstagio)
        {
            case 0:
                NomeFalador = "ISSO É UM TEMPLATE";
                ConversaDialogo = "O TEXTO VAI IR AQUI";
                break;
        }
    }
}
