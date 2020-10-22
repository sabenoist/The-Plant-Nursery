using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ARPlantHandler : MonoBehaviour
{
    public int coinsWorth;
    public UnityEvent interactEvent;

    private int moneyAmount;
    private Boolean recentlyTapped;

    public void Start() {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        recentlyTapped = false;
    }

    public void UpdateMoneyText() {
        Text moneyText = GameObject.Find("Canvas").transform.GetChild(1).transform.GetChild(1).gameObject.GetComponent<Text>();
        moneyText.text = moneyAmount.ToString();
    }

    public void PlantTapped() {
        if (!recentlyTapped) {
            moneyAmount += coinsWorth;
            recentlyTapped = true;

            UpdateMoneyText();

            PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
        }
    }
    private void OnMouseDown() {
        interactEvent.Invoke();
    }
}
