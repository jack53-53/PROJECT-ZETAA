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
                    rt.anchoredPosition = new Vector3(-245, -157, 0);
                    break;
                case 1:
                    rt.anchoredPosition = new Vector3(-245, -352, 0);
                    break;

            }
        }
        else
        {
            switch (ms.Opcao) //NAO FUNCIONAAAA
            {
                case 2:
                    rt.anchoredPosition = new Vector3(-149, 209, 0);
                    break;
                case 1:
                    rt.anchoredPosition = new Vector3(-149, -47, 0);
                    break;
                case 0:
                    rt.anchoredPosition = new Vector3(-149, -289, 0);
                    break;
            }
        }
    }
}
