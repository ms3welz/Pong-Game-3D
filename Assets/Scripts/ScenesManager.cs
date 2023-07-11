using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }

    public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
        Debug.Log("load scene " + scenename);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void LinkURL()
    {
        Application.OpenURL("https://github.com/msetyo15/Pong-Game-3D");
    }
}
