using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemPouchData {
    public static List<Item> items = new List<Item>();
    public static Item selectedItem = null;

    public static void AddItem(string name) {
        Item item = FindItem(name);

        if (item == null) {
            CreateItem(name, 1);
        } else {
            item.IncreaseAmount(1);
        }

        SaveItems();
    }

    public static Item FindItem(string name) {
        foreach (Item item in items) {
            if (item.GetName().Equals(name)) {
                return item;
            }
        }

        return null;
    }

    public static void CreateItem(string name, int amount) {
        Item newItem = new Item(name, amount);
        items.Add(newItem);
    }

    public static void DeleteItem(string name) {
        Item item = FindItem(name);

        if (item != null) {
            items.Remove(item);
            SaveItems();
        }
    }

    public static void SaveItems() {
        if (!PlayerPrefs.HasKey("Water")) PlayerPrefs.SetInt("Water", 0);
        if (!PlayerPrefs.HasKey("Fertilizer")) PlayerPrefs.SetInt("Fertilizer", 0);
        if (!PlayerPrefs.HasKey("Plant Pot")) PlayerPrefs.SetInt("Plant Pot", 0);

        foreach (Item item in items) {
            PlayerPrefs.SetInt(item.GetName(), item.GetAmount());
        }
    }

    public static void LoadItems() {
        items = new List<Item>();

        int waterAmount = PlayerPrefs.GetInt("Water");
        int fertilizerAmount = PlayerPrefs.GetInt("Fertilizer");
        int plantPotAmount = PlayerPrefs.GetInt("Plant Pot");

        if (waterAmount > 0) {
            CreateItem("Water", waterAmount);
        }
        if (fertilizerAmount > 0) {
            CreateItem("Fertilizer", fertilizerAmount);
        }
        if (plantPotAmount > 0) {
            CreateItem("Plant Pot", plantPotAmount);
        }
    }

    public static void ResetItems() {
        PlayerPrefs.SetInt("Water", 0);
        PlayerPrefs.SetInt("Fertilizer", 0);
        PlayerPrefs.SetInt("Plant Pot", 0);

        items = new List<Item>();
    }
}
