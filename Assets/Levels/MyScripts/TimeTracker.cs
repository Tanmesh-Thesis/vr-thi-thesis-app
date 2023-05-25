using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeTracker : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;
    private static float startTime;
    public static bool isTimerRunning;
    private bool sendData;
    void Start()
    {
        StartTimer();
        sendData = false;
    }

    void Update()
    {
        CalculateTime();
    }

    private void StartTimer()
    {
        startTime = Time.time;
        isTimerRunning = true;
    }

    public void CalculateTime()
    {
        if (isTimerRunning)
        {
            float elapsedTime = Time.time - startTime;
            DisplayTime(elapsedTime);
        }
        else if (!sendData)
        {
            float elapsedTime = Time.time - startTime;
            int seconds = Mathf.FloorToInt(elapsedTime % 60f);
            //Debug.Log("the elapsed time"+seconds);
            CarManager.receiveData = true;
            if (seconds > 15)
            {
                CarManager.userSuccess = false;
            }
            else
            {
                CarManager.userSuccess = true;
            }
            sendData = true;
        }
    }

    private void DisplayTime(float elapsedTime)
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);

        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timeText.SetText(timeString);
    }
}