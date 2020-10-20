using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARItemHandler : MonoBehaviour {
    public string type;

    void Start() {
        
    }


    void Update() {
        
    }

    public void itemTapped() {
        MapData.itemCaptured = true;

        //create item for item menu here
        Debug.LogWarning(type + " was tapped!");

        gameObject.Destroy();
    }
}
