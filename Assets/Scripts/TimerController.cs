using UnityEngine;
using TMPro;
using System;

public class TimerController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    public float timer;   // Timer value in seconds
    private bool isPaused;

    private void Start()
    {
        isPaused = false;
    }

    void Update()
    {
        if (!isPaused) // Only update the timer if not paused
        {
            timer += Time.deltaTime;

            int minutes = Mathf.FloorToInt(timer / 60);
            int seconds = Mathf.FloorToInt(timer % 60);
            int centiseconds = Mathf.FloorToInt((timer * 100) % 100);

            timerText.text = $"Time: {minutes:00}:{seconds:00}:{centiseconds:00}";
        }
    }

    public void SetPauseState(bool pause)
    {
        isPaused = pause;
    }
}
