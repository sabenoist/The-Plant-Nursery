using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapItemHandler : MonoBehaviour {
    public int maxDistance;
    public int minDistance;

    public Material testAway;
    public Material testProximate;

    void Start() {
        MapData.itemsOnMap.Add(gameObject);
    }

    void Update() {
        if (Vector3.Distance(MapData.player.transform.position, transform.position) > maxDistance) {
            DestroyItem();
        } else {
            ProximityCheck();
        }       
    }

    public void ProximityCheck() {
        if (Vector3.Distance(MapData.player.transform.position, transform.position) < minDistance && MapData.proximateItem == null) {
            MapData.proximateItem = gameObject;
            gameObject.GetComponent<MeshRenderer>().material = testProximate;

        } else if (Vector3.Distance(MapData.player.transform.position, transform.position) > minDistance && MapData.proximateItem == gameObject) {
            MapData.proximateItem = null;
            gameObject.GetComponent<MeshRenderer>().material = testAway;
        }
    }

    public void DestroyItem() {
        MainMenuController.itemCounter--;

        if (MapData.proximateItem == gameObject) {
            MapData.proximateItem = null;
        }

        MapData.itemsOnMap.Remove(gameObject);
        Destroy(gameObject);
    }
}
