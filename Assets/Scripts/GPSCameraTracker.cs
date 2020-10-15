using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GPSCameraTracker : MonoBehaviour {
    //private Transform target;
    public float xOffset;
    public float yOffset;
    public float zOffset;

    void Start() {
        MapData.camera = gameObject;
        transform.Rotate(60, 0, 0);
    }
    void Update() {
        transform.position = new Vector3(MapData.player.transform.position.x + xOffset, MapData.player.transform.position.y + yOffset, MapData.player.transform.position.z + zOffset);
    }
}
