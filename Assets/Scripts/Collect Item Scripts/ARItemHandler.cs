using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class ARItemHandler : MonoBehaviour {
    public UnityEvent interactEvent;

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

    private void OnMouseDown() {
        interactEvent.Invoke();
    }
}
