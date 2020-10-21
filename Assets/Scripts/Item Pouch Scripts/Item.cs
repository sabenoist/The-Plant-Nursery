using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    private string name;
    private int amount;

    public Item(string name, int amount) {
        this.name = name;
        this.amount = amount;
    }

    public string GetName() {
        return name;
    }

    public int GetAmount() {
        return amount;
    }

    public void IncreaseAmount(int increase) {
        amount += increase;
        ItemPouchData.SaveItems();
    }

    public void DecreaseAmount(int decrease) {
        amount -= decrease;

        if (amount < 1) {
            ItemPouchData.items.Remove(this);
        }
        ItemPouchData.SaveItems();
    }
}
