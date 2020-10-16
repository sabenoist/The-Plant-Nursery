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

    public Button buyButton;

    // Use this for initialization
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
    }

    // Update is called once per frame
    void Update()
    {

        moneyAmountText.text = moneyAmount.ToString();

        isItemSold = PlayerPrefs.GetInt("IsItemSold");

        if (moneyAmount >= 50 && isItemSold == 0)
            buyButton.interactable = true;
        else
            buyButton.interactable = false;
    }

    public void buyItem()
    {
        moneyAmount -= 50;
        PlayerPrefs.SetInt("IsItemSold", 1);
       // itemPrice.text = "Sold!";
        buyButton.gameObject.SetActive(false);
    }

    public void exitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
       
    }


    //public void delete()
  //  {

    //    buyButton.gameObject.SetActive(true);

      //  PlayerPrefs.DeleteAll();
   // }

}
