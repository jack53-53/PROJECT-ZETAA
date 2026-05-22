using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScript : MonoBehaviour
{
    public float Cooldown;

    private void Update()
    {
        Cooldown -= Time.fixedDeltaTime;
        if( Cooldown < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
