using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanel : MonoBehaviour {
    public Sprite waterSprite;
    public Sprite fertilizerSprite;
    public Sprite potSprite;

    Image image;
    Text itemName;
    Text amount;

    Item item;

    void Start() {
        image = gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
        itemName = gameObject.transform.GetChild(1).gameObject.GetComponent<Text>();
        amount = gameObject.transform.GetChild(2).gameObject.GetComponent<Text>();
    }

    public void setItem(Item data) {
        item = data;

        itemName.text = data.getName();
        amount.text = data.getAmount().ToString();

        if (data.getName().Equals("water")) {
            image.sprite = waterSprite;
        } else if (data.getName().Equals("fertilizer")) {
            image.sprite = fertilizerSprite;
        } else if (data.getName().Equals("pot")) {
            image.sprite = potSprite;
        }
    }

    public void itemClicked() {
        ItemPouchData.selectedItem = item;
    }
}
