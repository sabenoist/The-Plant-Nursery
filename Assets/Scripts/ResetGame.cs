using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public void resetPlayerPrefs()
    {
       // moneyAmount = 100;
      
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("MoneyAmount", 500);
    }
}
