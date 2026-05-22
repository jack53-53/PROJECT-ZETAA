using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScript : MonoBehaviour
{
    public float Cooldown;

    private void Update()
    {
        if( Cooldown < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void FixedUpdate()
    {
        Cooldown -= Time.fixedDeltaTime;
    }
}
