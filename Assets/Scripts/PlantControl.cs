using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlantControl : MonoBehaviour
{

    public Text moneyText;
    public static int moneyAmount;
    int isItemSold;
    public GameObject item;

    // Use this for initialization
  //  
    void awake()
    {
        PlayerPrefs.SetInt("MoneyAmount", 200);
    }
      void Start()
    {
        
      moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
      isItemSold = PlayerPrefs.GetInt("IsItemSold");

      if (isItemSold == 1)
          item.SetActive(true);
      else
          item.SetActive(false);
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
    public void delete()
    {

       // buyButton.gameObject.SetActive(true);

        PlayerPrefs.DeleteAll();
        item.SetActive(false);
    }
}