using UnityEngine;
using UnityEngine.SceneManagement;

public class Dialogo1LadyDona : FaladorScript
{

    //public AudioClip audio1;
    //public AudioClip audio2;
    //public AudioClip audio3;
    //public AudioSource AS;

    private void Start()
    {
        //AS = GetComponent<AudioSource>();
    }

    private void Update()
    {
        
        switch (ConversaEstagio)
        {
            case 0:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "Então Lady Donna… como é que o gato saiu de casa?";
                //AS.clip = audio1;
                //if (!Tocou)
                //{
                //    AS.Play();
                //    Tocou = true;
                //}
                break;
            case 1:
                NomeFalador = "Lady Donna";
                ConversaDialogo = "Oh, pela porta filho.";
                //AS.clip = audio2;
                //AS.Play();
                break;
            case 2:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "E quem abriu a porta?";
                //AS.clip = audio3;
                //AS.Play();
                break;
            case 3:
                NomeFalador = "Lady Donna: ";
                ConversaDialogo = "Oh, devo ter sido eu. Mas não me lembro de ver o gato a fugir, eu tava a dar-lhe comidinha quando me chamaram.";
                //AS.clip = audio2;
                //AS.Play();
                break;
            case 4:
                NomeFalador = "Detective S.C: ";
                ConversaDialogo = "Impossível. O gato morreu.";
                //AS.clip = audio1;
                //AS.Play();
                break;
            case 5:
                NomeFalador = "Lady Donna:";
                ConversaDialogo = "Oh o gato morreu? Então quem é aquele a comer?";
                //AS.clip = audio2;
                //AS.Play();
                break;
            case 6:
                SceneManager.LoadScene("Nivel1 1");
                break;
        }
    }
}
