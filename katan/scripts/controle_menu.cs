using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle_menu : MonoBehaviour
{
    public void modo_historia()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nome da scene");
    }
    public void versus()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nome da scene");
    }
    public void configuração()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nome da scene");
    }
    public void sair()
    {
        Application.Quit();

    }


}
