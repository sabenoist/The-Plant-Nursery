using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapItemHandler : MonoBehaviour {
    public string itemType = "none";

    public int maxDistance;
    public int minDistance;

    public GameObject proximateItemMarkerPrefab;

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

            MapData.proximateItemMarker = Instantiate(proximateItemMarkerPrefab, transform.position, Quaternion.identity);
            MapData.proximateItemMarker.transform.Rotate(-90,0,0);
        } else if (Vector3.Distance(MapData.player.transform.position, transform.position) > minDistance && MapData.proximateItem == gameObject) {
            MapData.proximateItem = null;
            MapData.proximateItemMarker.Destroy();
            MapData.proximateItemMarker = null;
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
