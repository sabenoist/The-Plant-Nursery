using Mapbox.Unity.Location;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    private string name;
    private int amount;

    public Item(string type) {
        name = type;
        amount = 1;
    }

    public string getName() {
        return name;
    }

    public int getAmount() {
        return amount;
    }

    public void increaseAmount(int increase) {
        amount += increase;
    }

    public void decreaseAmount(int decrease) {
        amount -= decrease;

        if (amount < 1) {
            ItemPouchData.items.Remove(this);
        }
    }
}
