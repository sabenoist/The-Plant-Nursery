using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class ARItemHandler : MonoBehaviour {
    public UnityEvent interactEvent;

    public string type;

    public void itemTapped() {
        MapData.itemCaptured = true;

        ItemPouchData.createItem(type);

        gameObject.Destroy();
    }

    private void OnMouseDown() {
        interactEvent.Invoke();
    }
}
