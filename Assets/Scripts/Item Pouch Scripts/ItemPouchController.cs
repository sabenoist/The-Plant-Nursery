using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPouchController : MonoBehaviour {
    public GameObject itemPanelPrefab;

    void Start() {
        ItemPouchData.LoadItems();

        GameObject items = GameObject.Find("Items Panel");

        foreach (Item item in ItemPouchData.items) {
            GameObject panel = Instantiate(itemPanelPrefab, items.transform);
            panel.GetComponent<ItemPanel>().InitItem(item);
        }
    }

    void Update() {
        
    }
}
