using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglePauseMenu : MonoBehaviour
{

    public static bool gameIsPaused = false;
    public GameObject pauseMenu;

    // Update is called once per frame
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        gameIsPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;

    }
    void Pause()
    {
        gameIsPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void BtnCheck()
    {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
        }
    }
}
