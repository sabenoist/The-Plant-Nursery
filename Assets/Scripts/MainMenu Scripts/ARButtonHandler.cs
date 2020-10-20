﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARButtonHandler : MonoBehaviour {
    private Button button;

    // Start is called before the first frame update
    void Start() {
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update() {
        if (MapData.proximateItem == null) {
            button.interactable = false;
        } else {
            button.interactable = true;
        }
    }
}
