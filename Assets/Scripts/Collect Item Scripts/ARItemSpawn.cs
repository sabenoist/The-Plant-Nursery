using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARItemSpawn : MonoBehaviour {
    public GameObject waterPrefab;
    public GameObject fertilizerPrefab;
    public GameObject potPrefab;

    public Vector3 size;
    public Vector3 center;

    void Start() {
        if (MapData.vrItem != null) {
            string type = MapData.vrItem.GetComponent<MapItemHandler>().itemType;
            SpawnItem(type);
        }
    }

    void Update() {
        
    }

    void SpawnItem(string type) {
        //Vector3 pos = center + new Vector3(Random.Range(transform.position.x - size.x / 2, MapData.player.transform.position.x + size.x / 2), Random.Range(MapData.player.transform.position.y - size.y / 2, MapData.player.transform.position.y + size.y / 2), Random.Range(MapData.player.transform.position.z - size.z / 2, MapData.player.transform.position.z + size.z / 2));
        Vector3 pos = center + new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(18, 20));


        if (type == "water") {
            GameObject water = Instantiate(waterPrefab, pos, Quaternion.identity);
            water.transform.Rotate(-90, 0, 0);
        } else if (type == "fertilizer") {
            GameObject fertilizer = Instantiate(fertilizerPrefab, pos, Quaternion.identity);
            fertilizer.transform.Rotate(20, 20, 0);
        } else if (type == "pot") {
            GameObject pot = Instantiate(potPrefab, pos, Quaternion.identity);
            pot.transform.Rotate(-90, 0, 0);
        }
    }
}
