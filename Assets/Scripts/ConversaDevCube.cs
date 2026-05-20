using UnityEngine;

public class ConversaDevCube : FaladorScript
{
    private void Update()
    {
        switch (ConversaEstagio)
        {
            case 0:
                NomeFalador = "CUBO";
                ConversaDialogo = "ESTOU EM MUITA DOR";
                break;
            case 1:
                NomeFalador = "EU";
                ConversaDialogo = "CONVERSA2 TCHAU";
                break;
            case 2:
                NomeFalador = "NOVA PISTA DESBLOQUEADA";
                ConversaDialogo = "AGORA VOCE SABE QUE O CUBO TEM DORES";
                break;
        }

    }
}
