using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DATASCRIPT : MonoBehaviour
{
    public float SensSaved;
    public float SoundSaved;
    public string TextoDicas;
    public Image Anim;
    public GameObject AnimGO;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
