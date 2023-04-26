using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int controlsClicked = 0;
    public static bool userFailed;
    public static bool userSuccess;
    public GameObject loadSuccessfullScene;
    public GameObject currentScene;
    public GameObject loadCrashScene;
    public GameObject timeLoaderScene;
    void Start()
    {
        userFailed = false;
        userSuccess = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!userSuccess && controlsClicked == 2) {
            Debug.Log("success");
            loadSuccessfullScene.SetActive(true);
            currentScene.SetActive(false);
            //timeLoaderScene.SetActive(false);
            CarTimer.runTimer = false;
            userSuccess = true;
            controlsClicked = 0;
        }

        if(userFailed) {
             Debug.Log("failed");
            loadCrashScene.SetActive(true);
            currentScene.SetActive(false);
            userFailed = false;
        }
    }
}
