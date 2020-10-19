using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARButtonHandler : MonoBehaviour {
     void Update() {
        Button button = GetComponent<Button>();

        if (MapData.proximateItem != null) {
            button.interactable = true;
        } else {
            button.interactable = false;
        }
    }
}
