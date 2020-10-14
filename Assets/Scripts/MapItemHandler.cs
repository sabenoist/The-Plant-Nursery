using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapItemHandler : MonoBehaviour {
    public static Transform playerTarget;
    public int maxDistance;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Vector3.Distance(playerTarget.position, transform.position) > maxDistance) {
            DestroyItem();
        }        
    }

    public void DestroyItem() {
        SpawnItemHandler.itemCounter--;
        Destroy(gameObject);
    }
}
