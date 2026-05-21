using UnityEngine;
using UnityEngine.SceneManagement;

public class Dialogo1Crystal : FaladorScript
{
    private void Update()
    {
        switch (ConversaEstagio)
        {
            case 0:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "O que estava a fazer no corredor?";
                break;
            case 1:
                NomeFalador = "Crystal";
                ConversaDialogo = "Estava a caminho de um casting, que inclusive perdi…";
                break;
            case 2:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "Casting?";
                break;
            case 3:
                NomeFalador = "Crystal";
                ConversaDialogo = "Sim… sou modelo… obviamente.";
                break;
            case 4:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "Tinha alguma relação com a vítima?";
                break;
            case 5:
                NomeFalador = "Crystal: ";
                ConversaDialogo = "Com o gato? Uh… Não.";
                break;
            case 6:
                NomeFalador = "Detective S.C.:";
                ConversaDialogo = "E com a Lady Donna?";
                break;
            case 7:
                NomeFalador = "Crystal: ";
                ConversaDialogo = "Cumprimento-a mas ela só fica confusa… acho que ela não vê muito bem, deve confundir-me com um poste.";
                break;
            case 8:
                SceneManager.LoadScene("Nivel2 1");
                break;
        }
    }
}
