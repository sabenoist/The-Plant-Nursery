using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPouchController : MonoBehaviour {
    GameObject itemPanelPrefab;

    void Start() {
        GameObject items = GameObject.Find("Items Panel");

        foreach (Item item in ItemPouchData.items) {
            GameObject panel = Instantiate(itemPanelPrefab);
            panel.transform.SetParent(items.transform);

            ItemPanel itemScript = (ItemPanel)panel.GetComponent(typeof(ItemPanel));
            itemScript.setItem(item);

            Debug.LogWarning("created item " + item.getName() + "!");
        }
    }

    void Update() {
        
    }
}
