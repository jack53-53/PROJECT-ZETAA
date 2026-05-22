using UnityEngine;

public class MusicaScript : MonoBehaviour
{
    public AudioSource AS;
    private GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this);
        AS = GetComponent<AudioSource>();
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
