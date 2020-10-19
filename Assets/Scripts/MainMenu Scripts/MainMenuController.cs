using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngineInternal;

public class MainMenuController : MonoBehaviour {
    public GameObject waterPrefab;
    public GameObject fertilizerPrefab;
    public GameObject potPrefab;

    public int chanceWater = 80;
    public int chanceFertilizer = 10;

    public GameObject mapPrefab;
    public GameObject cameraPrefab;

    public Vector3 center;
    public Vector3 size;

    public int maxItems;
    public static int itemCounter;
    public int minDistanceToPlayer;

    // Start is called before the first frame update
    void Start() {
        if (MapData.gameControllerExists) {
            Destroy(gameObject);
            return;
        }

        MapData.gameControllerExists = true;

        if (MapData.map == null) {
            Instantiate(mapPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            GameObject map = GameObject.Find("PlayerMap(Clone)");
            GameObject player = map.transform.Find("PlayerTarget").gameObject;
            GameObject maptile = map.transform.Find("Map").gameObject;

            MapData.map = map;
            MapData.mapTile = maptile;
            MapData.player = player;
        }

        if (MapData.camera == null) {
            Instantiate(cameraPrefab, new Vector3(0, 20, -10), Quaternion.identity);
        }

        for (int i = 0; i < maxItems; i++) {
            Spawn();
        }
    }

    // Update is called once per frame
    void Update() {
        if (itemCounter < maxItems) {
            Spawn();
        }

        if (MapData.itemCaptured && MapData.vrItem != null) {
            MapData.itemsOnMap.Remove(MapData.vrItem);
            itemCounter--;

            if (MapData.proximateItem == MapData.vrItem) {
                MapData.proximateItem = null;
            }

            MapData.vrItem.Destroy();
            MapData.vrItem = null;
            MapData.itemCaptured = false;
        }
    }

    public void Spawn() {
        Vector3 pos;

        do {
            pos = center + new Vector3(Random.Range(MapData.player.transform.position.x - size.x / 2, MapData.player.transform.position.x + size.x / 2), 2, Random.Range(MapData.player.transform.position.z - size.z / 2, MapData.player.transform.position.z + size.z / 2));
        } while (Vector3.Distance(pos, MapData.player.transform.position) < minDistanceToPlayer);

        int randomNumber = Random.Range(1, 100);

        if (randomNumber < chanceWater) {
            Instantiate(waterPrefab, pos, Quaternion.identity);
        } else if (randomNumber < chanceFertilizer + chanceWater) {
            Instantiate(fertilizerPrefab, pos, Quaternion.identity);
        } else {
            Instantiate(potPrefab, pos, Quaternion.identity);
        }

        itemCounter++;
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }
}
