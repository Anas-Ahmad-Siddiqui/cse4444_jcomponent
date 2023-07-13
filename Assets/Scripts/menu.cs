using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public void GoToLoading()
    {
        SceneManager.LoadScene("loading");
    }

    public void GoToHelp()
    {
        SceneManager.LoadScene("howto");
    }

    public void GoToAbout()
    {
        SceneManager.LoadScene("about");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
