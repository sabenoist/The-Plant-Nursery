using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private lokalPlantHandler LocalPlantHandler;

    public void changeScene(string SceneName)
	{
		if (SceneName.Equals("Main Menu")) {
			ShowMap();
        } else if (SceneManager.GetActiveScene().name.Equals("Main Menu")) {
			HideMap();
        }

		if (SceneName.Equals("Collect Item AR View")) {
			MapData.vrItem = MapData.proximateItem;
        } 

		SceneManager.LoadScene(SceneName);
	}

    public void changeSceneToAR(int activePlant)
    {
        LocalPlantHandler = GameObject.Find("LokalPlantHandlerGO").GetComponent<lokalPlantHandler>();
        LocalPlantHandler.selectPlant(activePlant);
        SceneManager.LoadScene("AR Plant Scene");


    }

    public void ShowMap() {
		if (MapData.map == null || MapData.camera == null) {
			return;
        }

		MapData.mapTile.SetActive(true);
		MapData.player.SetActive(true);
		MapData.camera.SetActive(true);

		foreach (GameObject item in MapData.itemsOnMap) {
			item.SetActive(true);
		}
	}

	public void HideMap() {
		MapData.mapTile.SetActive(false);
		MapData.player.SetActive(false);
		MapData.camera.SetActive(false);

		foreach (GameObject item in MapData.itemsOnMap) {
			item.SetActive(false);
        }
    }
}
