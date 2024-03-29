using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 60f;
    private bool isTimerRunnung = false;
    private float currentTime;
    public Text timerText;
    private void Start()
    {
        isTimerRunnung = true;
        currentTime = timeValue;
    }
    private void Update()
    {
        if (isTimerRunnung)
        {
            currentTime = currentTime - Time.deltaTime;
            if(currentTime <= 0.0f)
            {
                currentTime = 0.0f;
                isTimerRunnung = false;
            }
            UpdateTimerText();
        }
    }
    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60.0f);
        int seconds = Mathf.FloorToInt(currentTime % 60.0f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
