﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using IPlantInterface.cs;
using System.CodeDom.Compiler;
using System.Dynamic;


public class ShopControl : MonoBehaviour
{
    private lokalPlantHandler LocalPlantHandler;
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


    // Use this for initialization
    void Start()
    {
       
        if (!PlayerPrefs.HasKey("MoneyAmount")) PlayerPrefs.SetInt("MoneyAmount", 500); //check if no MoneyAmount PlayerPrefs, then initialize PlayerPrefs money amount
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");

    }

    // Update is called once per frame
    void Update()
    {
        
        moneyAmountText.text = moneyAmount.ToString(); //mooneyAmount is int

        isItemSold1 = PlayerPrefs.GetInt("IsItemSold1");
        isItemSold2 = PlayerPrefs.GetInt("IsItemSold2");
        isItemSold3 = PlayerPrefs.GetInt("IsItemSold3");

        if (moneyAmount >= 50)
        {
           
            buyButton1.interactable = true;
        }
        else
            buyButton1.interactable = false;

        if (moneyAmount >= 100)
        {
            buyButton2.interactable = true;
        }
        else
            buyButton2.interactable = false;

        if (moneyAmount >= 150)
        {
            buyButton3.interactable = true;
        }
        else
        {
            buyButton3.interactable = false;
        }

        if (moneyAmount >= 150)
        {
            buyButton4.interactable = true;
        }
        else
        {
            buyButton4.interactable = false;
        }
    }

    public void buyItem1() //refer to plant1 buyButton , if item 1 is sold, set priceText to sold, disable buybutton
    {
        moneyAmount -= 50;
        PlayerPrefs.SetInt("IsItemSold1", 1);
        //itemPrice1.text = "Sold!";
        //buyButton1.gameObject.SetActive(false);

        LocalPlantHandler = GameObject.Find("test").GetComponent<lokalPlantHandler>(); //get lokalPlantHandler script in test gameobject
        LocalPlantHandler.createPlant(1); //call createPlant function, sent int 1 to create plantType 1

        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);

    }

    public void buyItem2()
    {
        moneyAmount -= 100;
        PlayerPrefs.SetInt("IsItemSold2", 2);
        //itemPrice2.text = "Sold!";
       // buyButton2.gameObject.SetActive(false);
        LocalPlantHandler = GameObject.Find("test").GetComponent<lokalPlantHandler>();
        LocalPlantHandler.createPlant(2);

        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);

    }

    public void buyItem3()
    {
        moneyAmount -= 150;
        PlayerPrefs.SetInt("IsItemSold3", 3);
       // itemPrice3.text = "Sold!";
       // buyButton3.gameObject.SetActive(false);
        LocalPlantHandler = GameObject.Find("test").GetComponent<lokalPlantHandler>();
        LocalPlantHandler.createPlant(3);

        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
    }

    public void buyItem4()
    {
        moneyAmount -= 150;
        ItemPouchData.AddItem("Fertilizer");

        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
    }

    public void exitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);//when exit shop and back to my plant, set playerPrefs

    }

    /*
    public void resetPlayerPrefs()
    {
        //moneyAmount = 150;
       // buyButton1.gameObject.SetActive(true);
       // buyButton2.gameObject.SetActive(true);
       // buyButton3.gameObject.SetActive(true);
        PlayerPrefs.DeleteAll();
    }
    */
    

}
