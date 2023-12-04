using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class coutdownTimer2 : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float startTime = 60f;
    private float currentTime;
    //[SerializeField] private AudioSource deathSoundEffect;
    private AudioSource deathAudioSource;




    // Start is called before the first frame update
    void Start()
    {
        deathAudioSource = GetComponent<AudioSource>();
        currentTime = startTime;
        UpdateTimerText();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0f)
        {
            currentTime = 0f;
            RestartGame();
        }

        UpdateTimerText();

    }
    void UpdateTimerText()
    {
        timerText.SetText(currentTime.ToString("0"));
    }
    void RestartGame()
    {
        // Reload the current scene
        deathAudioSource.Play();

        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }


}

