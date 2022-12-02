using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tryUIcanvasManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int numberOfSymbolClickedInequation;
    public static List<GameObject> selectedAssets = new List<GameObject>();

    public GameObject deactivateScene;
    public GameObject loadFinalScene;
    public string resulttext;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(numberOfSymbolClickedInequation == 5) {
            deactivateScene.SetActive(false);
            loadFinalScene.SetActive(true);
            numberOfSymbolClickedInequation = 0;
            foreach( var assets in selectedAssets) {
                //Debug.Log(assets.ToString().Split(" ")[0]);
                resulttext = resulttext + " " + assets.ToString().Split(" ")[0];
            }
            //Debug.Log(resulttext);
            tryFinalCanvas.finalText = resulttext;
        }
    }
}
