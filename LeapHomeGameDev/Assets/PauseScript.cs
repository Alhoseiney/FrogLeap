using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    private bool isPaused = false;
    private float previousTimeScale;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void OnPauseButtonClick()
    {
        TogglePause();
    }

    private void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            previousTimeScale = Time.timeScale;
            Time.timeScale = 0f; // Pause the game
            Debug.Log("Game Paused");
        }
        else
        {
            Time.timeScale = previousTimeScale; // Resume the game
            Debug.Log("Game Resumed");
        }
    }
}
