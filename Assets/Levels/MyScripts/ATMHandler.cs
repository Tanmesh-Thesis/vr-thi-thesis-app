using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject turnOnAtm;
    public GameObject turnOffAtm;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnOnATM() {
        if(turnOnAtm) {
            turnOnAtm.SetActive(true);
        }
        if(turnOffAtm) {
            turnOffAtm.SetActive(false);
        }
    }
}
