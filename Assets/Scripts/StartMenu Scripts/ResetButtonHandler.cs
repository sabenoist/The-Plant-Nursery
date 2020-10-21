using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButtonHandler : MonoBehaviour {
    public void ResetGame() {
        ItemPouchData.ResetItems();
    }
}
