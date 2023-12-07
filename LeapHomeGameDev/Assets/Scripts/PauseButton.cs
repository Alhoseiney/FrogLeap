using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public void Start()
    {
        Time.timeScale = 1;
        //pauseMenuScreen.SetActive(true);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        //pauseMenuScreen.SetActive(true);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        //pauseMenuScreen.SetActive(false);
    }
}
