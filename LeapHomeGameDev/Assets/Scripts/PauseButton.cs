using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public void ResumeButtonClicked()
    {
        Resume();
    }

    public void PauseButtonClicked()
    {
        Pause();
    }

    private void Update(){

        if(Input.GetKeyDown(KeyCode.Escape)) {
        
            if (GameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }

        
        }
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;  
    }

    //public void Start()
    //{
    //    Time.timeScale = 1;
    //    //pauseMenuScreen.SetActive(true);
    //}

    //public void PauseGame()
    //{
    //    Time.timeScale = 0;
    //    //pauseMenuScreen.SetActive(true);
    //}
    //public void ResumeGame()
    //{
    //    Time.timeScale = 1;
    //    //pauseMenuScreen.SetActive(false);
    //}
}
