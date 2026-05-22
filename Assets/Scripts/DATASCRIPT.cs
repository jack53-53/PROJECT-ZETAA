using UnityEngine;
using UnityEngine.SceneManagement;

public class DATASCRIPT : MonoBehaviour
{
    public float SensSaved;
    public float SoundSaved;
    public string TextoDicas;
    public GameObject AnimGO;

    //public AudioSource Musica;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        //Musica.loop = true;
        //Musica.Play();
    }
}
