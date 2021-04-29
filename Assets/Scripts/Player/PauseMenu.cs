using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField]
    private GameObject pausePanel;
    [SerializeField]
    private FPSController controller;

    [SerializeField]
    private GameObject gameplayUiElements;

    [SerializeField]
    private InteractCast iCast;

    [SerializeField]
    private bool IsPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
            if (!IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
            
        }
    }


    public void Pause()
    {
        gameplayUiElements.SetActive(false);
        iCast.CastEnabled = false;
        controller.unlockCursor();
        controller.canMove = false;
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }

    public void Resume()
    {
        gameplayUiElements.SetActive(true);
        controller.lockCursor();
        controller.canMove = true;
        iCast.CastEnabled = true;
        Time.timeScale = 1.0f;
        pausePanel.SetActive(false);
    }

    public void Quit()
    {
        Resume();
        controller.unlockCursor();
        SceneManager.LoadScene(0);
    }


    public void ReturnToHub()
    {
        Resume();
        SceneManager.LoadScene(1);
    }
}
