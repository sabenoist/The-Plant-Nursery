using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControl : MonoBehaviour
{

    int moneyAmount;
    int isItemSold;

    public Text moneyAmountText;
    public Text itemPrice;
    public Image soldImage;

    public Button buyButton;

    // Use this for initialization
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
            soldImage.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        moneyAmountText.text = moneyAmount.ToString();

        isItemSold = PlayerPrefs.GetInt("IsItemSold");

        if (moneyAmount >= 50 && isItemSold == 0)
        {
            buyButton.interactable = true;
            soldImage.enabled = false;
        }
        else
            buyButton.interactable = false;
            soldImage.enabled = true;
    }

    public void buyItem()
    {
        moneyAmount -= 50;
        PlayerPrefs.SetInt("IsItemSold", 1);
       
        buyButton.gameObject.SetActive(false);
    }

    public void exitShop()
    {
       PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
       
    }


    public void resetPlayerPrefs()
    {
        moneyAmount = 100;
        buyButton.gameObject.SetActive(true);
        PlayerPrefs.DeleteAll();
    }

}
