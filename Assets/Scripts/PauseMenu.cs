using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = true;

    public GameObject PauseMenuUI;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //Schultertaste
        {
            if (GameIsPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }

            GameIsPaused = !GameIsPaused;
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}