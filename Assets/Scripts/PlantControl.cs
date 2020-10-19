using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using IPlantInterface.cs;

public class PlantControl : MonoBehaviour
{
    private GameObjectHandler MotherTree;

    public Text moneyText;
    public static int moneyAmount;
    int isItem1Sold;
    int isItem2Sold;
    int isItem3Sold;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;

    // Use this for initialization

    void Start()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();

        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        isItem1Sold = PlayerPrefs.GetInt("IsItemSold1");
        isItem2Sold = PlayerPrefs.GetInt("IsItemSold2");
        isItem3Sold = PlayerPrefs.GetInt("IsItemSold3");

        if (isItem1Sold == 1)
            item1.SetActive(true);
        else
            item1.SetActive(false);

        if (isItem2Sold == 2)
            item2.SetActive(true);
        else
            item2.SetActive(false);

        if (isItem3Sold == 3)
            item3.SetActive(true);
        else
            item3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = moneyAmount.ToString();

    }

    public void gotoStore()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);

    }
    public void delete1()
    {
        PlayerPrefs.DeleteAll();
        item1.SetActive(false);
    }

    public void delete2()
    {
        PlayerPrefs.DeleteAll();
        item2.SetActive(false);
    }

    public void delete3()
    {
        PlayerPrefs.DeleteAll();
        item3.SetActive(false);
    }

    public void selectPlant1()
    {
        MotherTree.selectPlant(1);
    }

    public void selectPlant2()
    {
        MotherTree.selectPlant(2);
    }

    public void selectPlant3()
    {
        MotherTree.selectPlant(3);
    }
}