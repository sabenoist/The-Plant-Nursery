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

    public string GetName() {
        return name;
    }

    public int GetAmount() {
        return amount;
    }

    public void IncreaseAmount(int increase) {
        amount += increase;
    }

    public void DecreaseAmount(int decrease) {
        amount -= decrease;

        if (amount < 1) {
            ItemPouchData.items.Remove(this);
        }
    }
}
