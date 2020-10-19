using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using IPlantInterface.cs;


public class ShopControl : MonoBehaviour
{
    private GameObjectHandler MotherTree;
    int moneyAmount;
    int isItemSold1;
    int isItemSold2;
    int isItemSold3;

    public Text moneyAmountText;
    public Text itemPrice1;
    public Text itemPrice2;
    public Text itemPrice3;
    public Button buyButton1;
    public Button buyButton2;
    public Button buyButton3;
    public Button buyButton4;
    public Button buyButton5;
    public Button buyButton6;

    // Use this for initialization
    void Start()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        if (!PlayerPrefs.HasKey("MoneyAmount")) PlayerPrefs.SetInt("MoneyAmount", 100);
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");

    }

    // Update is called once per frame
    void Update()
    {

        moneyAmountText.text = moneyAmount.ToString();

        isItemSold1 = PlayerPrefs.GetInt("IsItemSold1");
        isItemSold2 = PlayerPrefs.GetInt("IsItemSold2");
        isItemSold3 = PlayerPrefs.GetInt("IsItemSold3");

        if (moneyAmount >= 50 && isItemSold1 == 0)
        {
            buyButton1.interactable = true;
        }
        else
            buyButton1.interactable = false;

        if (moneyAmount >= 100 && isItemSold2 == 0)
        {
            buyButton2.interactable = true;
        }
        else
            buyButton2.interactable = false;

        if (moneyAmount >= 150 && isItemSold3 == 0)
        {
            buyButton3.interactable = true;
        }
        else
            buyButton3.interactable = false;

        if (moneyAmount <=150 )
        {
            buyButton4.interactable = false;
            buyButton5.interactable = false;
            buyButton6.interactable = false;
        }
        
    }

    public void buyItem1()
    {
        moneyAmount -= 50;
        PlayerPrefs.SetInt("IsItemSold1", 1);
        itemPrice1.text = "Sold!";
        buyButton1.gameObject.SetActive(false);
        MotherTree.createPlant(1);
    }

    public void buyItem2()
    {
        moneyAmount -= 100;
        PlayerPrefs.SetInt("IsItemSold2", 2);
        itemPrice2.text = "Sold!";
        buyButton2.gameObject.SetActive(false);
        MotherTree.createPlant(2);
    }

    public void buyItem3()
    {
        moneyAmount -= 150;
        PlayerPrefs.SetInt("IsItemSold3", 3);
        itemPrice3.text = "Sold!";
        buyButton3.gameObject.SetActive(false);
        MotherTree.createPlant(3);
    }

    public void exitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);

    }


    public void resetPlayerPrefs()
    {
        moneyAmount = 100;
       // buyButton1.gameObject.SetActive(true);
       // buyButton2.gameObject.SetActive(true);
       // buyButton3.gameObject.SetActive(true);
        PlayerPrefs.DeleteAll();
    }

}
