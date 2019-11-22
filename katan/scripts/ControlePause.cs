using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePause : MonoBehaviour
{
    public GameObject menu;
    static public bool estapausado;
    // Start is called before the first frame update
    void Start()
    {
        estapausado = false;
        menu = Instantiate(menu, menu.transform.position, menu.transform.rotation) as GameObject;
        Pause(false);
    }

    void Pause(bool statuspause)
    {
        estapausado = statuspause;
        menu.SetActive(estapausado);
        if(estapausado == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause(!estapausado);

        }
    }
}
