using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    public float timeRemaining = 60.0f; // Set the initial time remaining in seconds
    public Text timerText; // Reference to the Text UI element

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // Decrease the time remaining by the time since the last frame
            UpdateTimerDisplay();
        }
        else
        {
            // Time has run out, restart the game or perform any required actions
            RestartGame();
        }
    }

    void UpdateTimerDisplay()
    {
        // Update the text displayed on the UI element
        timerText.text = Mathf.RoundToInt(timeRemaining).ToString();
    }

    void RestartGame()
    {
        // Restart the game here
        // You can reload the scene or perform any other required actions
        // Example: SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
