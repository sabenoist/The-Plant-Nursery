using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public void changeScene(string SceneName)
	{
		if (SceneName.Equals("Main Menu")) {
			ShowMap();
        } else if (SceneManager.GetActiveScene().name.Equals("Main Menu")) {
			HideMap();
        }

		SceneManager.LoadScene(SceneName);
	}

	public void ShowMap() {
		if (MapData.map == null || MapData.camera == null) {
			return;
        }

		//MapData.map.SetActive(true);
		MapData.mapTile.SetActive(true);
		MapData.player.SetActive(true);
		MapData.camera.SetActive(true);

		foreach (GameObject item in MapData.itemsOnMap) {
			item.SetActive(true);
		}
	}

	public void HideMap() {
		//MapData.map.SetActive(false);
		MapData.mapTile.SetActive(false);
		MapData.player.SetActive(false);
		MapData.camera.SetActive(false);

		foreach (GameObject item in MapData.itemsOnMap) {
			item.SetActive(false);
        }
    }
}
