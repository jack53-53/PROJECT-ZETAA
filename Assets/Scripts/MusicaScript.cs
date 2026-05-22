using UnityEngine;

public class MusicaScript : MonoBehaviour
{
    public AudioSource AS;
    private GameObject Player;
    private GameObject d;
    private DATASCRIPT ds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        d = GameObject.FindGameObjectWithTag("DATA");
        ds = d.GetComponent<DATASCRIPT>();

        DontDestroyOnLoad(this);
        AS = GetComponent<AudioSource>();

        AS.volume = ds.SoundSaved;
        AS.Play();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if(Player != null)
        {
            this.transform.position = Player.transform.position;
        }
    }
}
