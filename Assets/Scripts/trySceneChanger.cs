using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class trySceneChanger : MonoBehaviour
{
   // Start is called before the first frame update
    public GameObject nextScene;
    public GameObject currentScene;
    public GameObject loadRequiredAsset;
    public GameObject disableRequiredAsset;
    public Button disableLoadedButton;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScene() {
        if(nextScene) {
            nextScene.SetActive(true);
        }
        if(currentScene) {
        currentScene.SetActive(false);
        }
    }

    public void loadRequestedAsset() {
        if(loadRequiredAsset) {
            loadRequiredAsset.SetActive(true);
        }
    }

    public void disableRequestedAsset() {
        disableRequiredAsset.SetActive(false);
    }

    public void disableButton() {
        //Debug.Log("disabling button" + disableLoadedButton.ToString());
        disableLoadedButton.interactable = false;
    }

    public void LoadScene(string SceneName){
        SceneManager.LoadScene(SceneName);
    }

    public void controlsClickedFromScreen() {
        CarManager.controlsClicked ++;
    }

    public void retryContols() {
        CarManager.controlsClicked = 0;
    }
    
}
