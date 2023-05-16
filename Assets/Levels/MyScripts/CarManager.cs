using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int controlsClicked = 0;
    public static bool userSuccess;
    public static bool receiveData;
    public GameObject loadSuccessfullScene;
    public GameObject currentScene;
    public GameObject loadCrashScene;
    public GameObject timeLoaderScene;
    void Start()
    {
        userSuccess = false;
        receiveData = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (controlsClicked == 3)
        {
            Debug.Log("success in carmanager");
            TimeTracker.isTimerRunning = false;
            controlsClicked = 0;
        }

        if (receiveData)
        {
            if (userSuccess)
            {
                loadSuccessfullScene.SetActive(true);
            }
            else
            {
                loadCrashScene.SetActive(true);
            }
            currentScene.SetActive(false);
        }
    }
}
