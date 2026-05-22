using UnityEngine;

public class SetaMenuScript : MonoBehaviour
{

    private GameObject go;
    private MenuManagerScript m;
    private SettingsScript ms;
    private bool Menu;
    private RectTransform rt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        go = GameObject.FindGameObjectWithTag("Player");
        m = go.GetComponent<MenuManagerScript>();
        ms = go.GetComponent<SettingsScript>();
        if (m != null)
        {
            Menu = true;
        }
        else if (ms != null)
        {
            Menu = false;
        }
        else
        {
            Debug.Log("ALGO DEU MUITO ERRADO");
        }
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Menu)
        {
            switch (m.Opcao)
            {
                case 0:
                    rt.anchoredPosition = new Vector3(-262, 83, 0);
                    break;
                case 1:
                    rt.anchoredPosition = new Vector3(-163, -95, 0);
                    break;

            }
        }
        else
        {
            switch (ms.Opcao) //NAO FUNCIONAAAA
            {
                case 2:
                    rt.anchoredPosition = new Vector3(-176, 388, 0);
                    break;
                case 1:
                    rt.anchoredPosition = new Vector3(-407, 182, 0);
                    break;
                case 0:
                    rt.anchoredPosition = new Vector3(-70, -25, 0);
                    break;
            }
        }
    }
}
