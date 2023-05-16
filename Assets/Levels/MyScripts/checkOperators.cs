using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkOperators : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Toggle operatorP;
    [SerializeField] private Toggle operatorG;
    [SerializeField] private Toggle operatorK;
    public string checkOperator;
    public GameObject successScene;
    public GameObject failureScene;
    

    public void OnSubmitButtonClicked()
    {
        bool operatorPstate = operatorP.isOn;
        bool operatorGstate = operatorG.isOn;
        bool operatorKstate = operatorK.isOn;

        // You can now use the toggle states as needed
        if(checkOperator == "turnOnTv"){
            if(!operatorGstate && operatorKstate && operatorPstate) {
                successScene.SetActive(true);
            }
            else
            {
                failureScene.SetActive(true);
            }
        }

        if(checkOperator == "perceiveN"){
            if(!operatorGstate && !operatorKstate && operatorPstate) {
                successScene.SetActive(true);
            }
            else
            {
                failureScene.SetActive(true);
            }
        }

        if(checkOperator == "openN" || checkOperator == "searchN" || checkOperator == "playN"){
            if(operatorGstate && operatorKstate && operatorPstate) {
                successScene.SetActive(true);
            }
            else
            {
                failureScene.SetActive(true);
            }
        }
        
    }
}
