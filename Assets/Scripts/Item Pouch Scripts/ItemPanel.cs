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
    }

    public void InitItem(Item data) {
        image = gameObject.transform.GetChild(0).gameObject.GetComponent<Image>();
        itemName = gameObject.transform.GetChild(1).gameObject.GetComponent<Text>();
        amount = gameObject.transform.GetChild(2).gameObject.GetComponent<Text>();

        SetItem(data);
    }

    public void SetItem(Item data) {
        item = data;

        itemName.text = data.GetName();
        amount.text = data.GetAmount().ToString();

        if (data.GetName().Equals("water")) {
            image.sprite = waterSprite;
        } else if (data.GetName().Equals("fertilizer")) {
            image.sprite = fertilizerSprite;
        } else if (data.GetName().Equals("pot")) {
            image.sprite = potSprite;
        }
    }

    public void ItemClicked() {
        ItemPouchData.selectedItem = item;
    }
}
