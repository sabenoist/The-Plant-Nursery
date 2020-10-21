using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemDeleteButton : MonoBehaviour {
    public void ButtonClicked() {
        ItemSceneController.item.DecreaseAmount(1);
        SceneManager.LoadScene("My Pouch");
    }
}
