using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class SpawnItemHandler : MonoBehaviour {
    public Transform playerTarget;
    public GameObject waterPrefab;

    public Vector3 center;
    public Vector3 size;

    public int maxItems;
    public static int itemCounter;
    public int minDistanceToPlayer;

    // Start is called before the first frame update
    void Start() {
        MapItemHandler.playerTarget = playerTarget;

        for (int i = 0; i < maxItems; i++) {
            Spawn();
        }
    }

    // Update is called once per frame
    void Update() {
        if (itemCounter < maxItems) {
            Spawn();
        }
    }

    public void Spawn() {
        Vector3 pos;

        do {
            pos = center + new Vector3(Random.Range(playerTarget.position.x - size.x / 2, playerTarget.position.x + size.x / 2), 2, Random.Range(playerTarget.position.z - size.z / 2, playerTarget.position.x + size.z / 2));
        } while (Vector3.Distance(pos, playerTarget.position) < minDistanceToPlayer);

        Instantiate(waterPrefab, pos, Quaternion.identity);

        itemCounter++;
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }
}
