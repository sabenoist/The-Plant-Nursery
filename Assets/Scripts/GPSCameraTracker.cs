using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GPSCameraTracker : MonoBehaviour {
    public Transform target;
    public float xOffset;
    public float yOffset;
    public float zOffset;

    void Update() {
        transform.position = new Vector3(target.position.x + xOffset, target.position.y + yOffset, target.position.z + zOffset);
    }
}
