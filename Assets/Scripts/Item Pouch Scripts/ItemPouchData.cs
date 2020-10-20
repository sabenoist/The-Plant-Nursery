using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemPouchData {
    public static List<Item> items = new List<Item>();
    public static Item selectedItem = null;

    public static void addItem(string name) {
        Item item = findItem(name);

        if (item == null) {
            createItem(name);
        } else {
            item.increaseAmount(1);
        }
    }

    public static Item findItem(string name) {
        foreach (Item item in items) {
            if (item.getName().Equals("name")) {
                return item;
            }
        }
        return null;
    }

    public static void createItem(string name) {
        Item newItem = new Item(name);
        items.Add(newItem);
    }

    public static void deleteItem(string name) {
        Item item = findItem(name);

        if (item != null) {
            items.Remove(item);
        }
    }
}
