using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour {
    public Transform playerTarget;
    public GameObject waterPrefab;

    public Vector3 center;
    public Vector3 size;

    public int maxItems;
    private int itemCounter;

    // Start is called before the first frame update
    void Start() {
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
        Vector3 pos = center + new Vector3(Random.Range(playerTarget.position.x - size.x / 2, playerTarget.position.x + size.x / 2), Random.Range(playerTarget.position.y - size.y / 2, playerTarget.position.y + size.y / 2), Random.Range(playerTarget.position.z - size.z / 2, playerTarget.position.x +  size.z / 2));

        Instantiate(waterPrefab, pos, Quaternion.identity);

        itemCounter++;
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition + center, size);
    }
}
