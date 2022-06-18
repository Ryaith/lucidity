using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int destination;
    public GameObject helpInfo;

    public void Exit()
    {
        Application.Quit();
    }


    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
