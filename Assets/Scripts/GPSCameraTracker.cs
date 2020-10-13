using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GPSCameraTracker : MonoBehaviour {
    public Transform target;
    public float distance;

    void Update() {
        transform.position = new Vector3(target.position.x, target.position.y + 20, target.position.z - distance);
    }
}
