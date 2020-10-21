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
   
    public GameObject[] IconsPlantA;
    public GameObject[] IconsPlantB;
    public GameObject[] IconsPlantC;

    public GameObject[] StatusPlantA;
    public GameObject[] StatusPlantB;
    public GameObject[] StatusPlantC;

    public GameObject[] WaterPlantA;
    public GameObject[] WaterPlantB;
    public GameObject[] WaterPlantC;

    private lokalPlantHandler LocalPlantHandler;

    // Use this for initialization

    void Start()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();

        LocalPlantHandler = GameObject.Find("LokalPlantHandlerGO").GetComponent<lokalPlantHandler>();
        for (int i = 0; i < 3; i++)
        {
            IconsPlantA[i].SetActive(false);
            IconsPlantB[i].SetActive(false);
            IconsPlantC[i].SetActive(false);

            StatusPlantA[i].SetActive(false);
            StatusPlantB[i].SetActive(false);
            StatusPlantC[i].SetActive(false);

      
        }

        WaterPlantA[0].SetActive(false);
        WaterPlantB[0].SetActive(false);
        WaterPlantC[0].SetActive(false);

        WaterPlantA[1].SetActive(false);
        WaterPlantB[1].SetActive(false);
        WaterPlantC[1].SetActive(false);

        for (int i = 0; i < 3; i++)
        {
            LocalPlantHandler.selectPlant(i);

            //DO NOT DELETE UNTIL HARDCODED STUFF IS GONE!
            if (!LocalPlantHandler.plantExists()) {
                break;
            }

            int plantType = LocalPlantHandler.getPlantType();
            int skin = LocalPlantHandler.getSkin();

            if (i == 0)
            {
                IconsPlantA[plantType].SetActive(true);
                StatusPlantA[skin-1].SetActive(true);
                WaterPlantA[0].SetActive(!LocalPlantHandler.isThirstyFunction());
                WaterPlantA[1].SetActive(LocalPlantHandler.isThirstyFunction());
            }

            if (i == 1)
            {
                IconsPlantB[plantType].SetActive(true);
                StatusPlantB[skin-1].SetActive(true);
                WaterPlantB[0].SetActive(!LocalPlantHandler.isThirstyFunction());
                WaterPlantB[1].SetActive(LocalPlantHandler.isThirstyFunction());
            }

            if (i == 2)
            {
                IconsPlantC[plantType].SetActive(true);
                StatusPlantC[skin-1].SetActive(true);
                WaterPlantC[0].SetActive(!LocalPlantHandler.isThirstyFunction());
                WaterPlantC[1].SetActive(LocalPlantHandler.isThirstyFunction());
            }
        }
    


        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        isItem1Sold = PlayerPrefs.GetInt("IsItemSold1");
        isItem2Sold = PlayerPrefs.GetInt("IsItemSold2");
        isItem3Sold = PlayerPrefs.GetInt("IsItemSold3");

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
    
    public void delete0()
    {
        LocalPlantHandler = GameObject.Find("LokalPlantHandlerGO").GetComponent<lokalPlantHandler>();
        LocalPlantHandler.selectPlant(0);
        int plantType = LocalPlantHandler.getPlantType();
        int skin = LocalPlantHandler.getSkin();
        IconsPlantA[plantType].SetActive(false);
        StatusPlantA[skin-1].SetActive(false);
        WaterPlantA[0].SetActive(false);
        WaterPlantA[1].SetActive(false);
        LocalPlantHandler.destroyPlant();
    }

    public void delete1()
    {
        LocalPlantHandler = GameObject.Find("LokalPlantHandlerGO").GetComponent<lokalPlantHandler>();
        LocalPlantHandler.selectPlant(1);
        int plantType = LocalPlantHandler.getPlantType();
        int skin = LocalPlantHandler.getSkin();
        IconsPlantB[plantType].SetActive(false);
        StatusPlantB[skin - 1].SetActive(false);
        WaterPlantB[0].SetActive(false);
        WaterPlantB[1].SetActive(false);
        LocalPlantHandler.destroyPlant();
    }

    public void delete2()
    {
        LocalPlantHandler = GameObject.Find("LokalPlantHandlerGO").GetComponent<lokalPlantHandler>();
        LocalPlantHandler.selectPlant(2);
        int plantType = LocalPlantHandler.getPlantType();
        int skin = LocalPlantHandler.getSkin();
        IconsPlantC[plantType].SetActive(false);
        StatusPlantC[skin - 1].SetActive(false);
        WaterPlantC[0].SetActive(false);
        WaterPlantC[1].SetActive(false);
        LocalPlantHandler.destroyPlant();
    }

    public void useItem(int plantSelector) {
        LocalPlantHandler.selectPlant(plantSelector);

        string item = ItemSceneController.item.GetName();
        ItemSceneController.item.DecreaseAmount(1);

        if (item.Equals("Water")) {
            LocalPlantHandler.watering();
        } else if (item.Equals("Fertilizer")) {
            LocalPlantHandler.fertilize();
        }

        SceneManager.LoadScene("My Pouch");
    }
}