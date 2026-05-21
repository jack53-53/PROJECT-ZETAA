using UnityEngine;

public class DATASCRIPT : MonoBehaviour
{
    public float SensSaved;
    public float SoundSaved;
    public string TextoDicas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
