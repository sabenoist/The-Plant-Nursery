using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARItemSpawn : MonoBehaviour {
    public GameObject waterPrefab;
    public GameObject fertilizerPrefab;
    public GameObject potPrefab;

    public Vector3 size;

    void Start() {
        if (MapData.vrItem != null) {
            string type = MapData.vrItem.GetComponent<MapItemHandler>().itemType;
            SpawnItem(type);
        }
    }

    void Update() {
        
    }

    void SpawnItem(string type) {
        Vector3 pos = transform.position + new Vector3(Random.Range(transform.position.x - size.x / 2, MapData.player.transform.position.x + size.x / 2), Random.Range(MapData.player.transform.position.y - size.y / 2, MapData.player.transform.position.y + size.y / 2), Random.Range(MapData.player.transform.position.z - size.z / 2, MapData.player.transform.position.z + size.z / 2));

        if (type == "water") {
            Instantiate(waterPrefab, pos, Quaternion.identity);
        } else if (type == "fertilizer") {
            Instantiate(fertilizerPrefab, pos, Quaternion.identity);
        } else if (type == "pot") {
            Instantiate(potPrefab, pos, Quaternion.identity);
        }
    }
}
