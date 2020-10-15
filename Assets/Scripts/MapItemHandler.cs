using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapItemHandler : MonoBehaviour {
    public static GameObject proximateItem;
    public static Transform playerTarget;

    public int maxDistance;
    public int minDistance;

    public Material testAway;
    public Material testProximate;

    // Start is called before the first frame update
    void Start() {
        proximateItem = null;
    }

    // Update is called once per frame
    void Update() {
        if (Vector3.Distance(playerTarget.position, transform.position) > maxDistance) {
            DestroyItem();
        } else {
            ProximityCheck();
        }       
    }

    public void ProximityCheck() {
        if (Vector3.Distance(playerTarget.position, transform.position) < minDistance && proximateItem == null) {
            proximateItem = gameObject;
            gameObject.GetComponent<MeshRenderer>().material = testProximate;

        } else if (Vector3.Distance(playerTarget.position, transform.position) > minDistance && proximateItem == gameObject) {
            proximateItem = null;
            gameObject.GetComponent<MeshRenderer>().material = testAway;
        }
    }

    public void DestroyItem() {
        SpawnItemHandler.itemCounter--;

        if (proximateItem == gameObject) {
            proximateItem = null;
        }

        Destroy(gameObject);
    }
}
