﻿using UnityEngine;
using UnityEngine.UI;

public class FullscreenToggle : MonoBehaviour {
    public Toggle toggle;

    void Start() {
        //Add listener for when the state of the Toggle changes, to take action
        toggle.onValueChanged.AddListener(_ => ToggleValueChanged(toggle));
    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change) {
        if (toggle.isOn == false) {
            Screen.fullScreen = !Screen.fullScreen;
            Debug.Log("FS disabled");
        }
        else {
            Screen.fullScreen = true;
            Debug.Log("FS enabled");
        }
    }
}