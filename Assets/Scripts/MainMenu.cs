using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    public void playButton()
    {
        SceneManager.LoadScene("Essay");
    }
    public void quitButton()
    {
        Application.Quit();
    }
}
