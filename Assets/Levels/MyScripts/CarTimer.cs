using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CarTimer : MonoBehaviour
{
    float currentTime;
    public static bool runTimer;
    public float startingTime = 10f;

    [SerializeField] TextMeshProUGUI countdownText;
    void Start()
    {
        currentTime = startingTime;
        runTimer = true;
    }
    void Update()
    {
        if(runTimer) {
            currentTime -= Time.deltaTime;
            //Debug.Log(currentTime);
            //Debug.Log(runTimer);
            countdownText.SetText(currentTime.ToString("0"));

            if (currentTime <= 0)
            {
                currentTime = 0;
                //CarManager.userFailed = true;
                runTimer = false;
            }
        }
        
    }
}