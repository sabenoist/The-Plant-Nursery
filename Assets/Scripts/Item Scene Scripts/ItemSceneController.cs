using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSceneController : MonoBehaviour {
    public Sprite waterSprite;
    public Sprite fertilizerSprite;
    public Sprite potSprite;

    Image image;
    Text title;
    Text description;

    public static Item item;

    void Start() {
        item = ItemPouchData.selectedItem;

        title = gameObject.transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Text>();
        image = gameObject.transform.GetChild(1).transform.GetChild(0).transform.GetChild(0).gameObject.GetComponent<Image>();
        description = gameObject.transform.GetChild(1).transform.GetChild(1).transform.GetChild(0).gameObject.GetComponent<Text>();

        SetInformation();
    }

    private void SetInformation() {
        string name = item.GetName();
        title.text = name;

        if (name.Equals("Water")) {
            SetWater();
        } else if (name.Equals("Plant Pot")) {
            SetPlantPot();
        } else if (name.Equals("Fertilizer")) {
            SetFertilizer();
        }
    }

    private void SetWater() {
        image.sprite = waterSprite;
        description.text = "Can be used on your plants to water them.";
    }

    private void SetPlantPot() {
        image.sprite = potSprite;
        description.text = "Can be combined with seeds to grow a new plant.";

        Button button = gameObject.transform.GetChild(2).transform.GetChild(2).gameObject.GetComponent<Button>();
        button.interactable = false;
    }

    private void SetFertilizer() {
        description.text = "Can be used on your plants to accelarate their growth.";
        image.sprite = fertilizerSprite;
    }

    void Update() {
        
    }
}
