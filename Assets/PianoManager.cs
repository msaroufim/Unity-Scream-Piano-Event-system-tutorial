using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoManager : MonoBehaviour {

    public int numberOfClicks = 0;

    void OnEnable() {
        PianoKeyScript.OnNumberOfClicksUpdate += HandleOnNumberOfClicksUpdated;
    }

    void OnDisable() {
        PianoKeyScript.OnNumberOfClicksUpdate -= HandleOnNumberOfClicksUpdated;

    }

    void Update()
    {
        Debug.Log(numberOfClicks);
    }


    void HandleOnNumberOfClicksUpdated() {
        numberOfClicks++;
        Debug.Log(numberOfClicks);
    }
}
