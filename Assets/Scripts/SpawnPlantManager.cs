using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IPlantInterface.cs;


public class SpawnPlantManager : MonoBehaviour
{
    private lokalPlantHandler LocalPlantHandler;
    public GameObject ObjectToSpawn;
    public PlacementManager pm;
    public GameObject[] PrefabPlantStagesPlantA;
    public GameObject[] PrefabPlantStagesPlantB;
    public GameObject[] PrefabPlantStagesPlantC;
    private int moneyAmount;




    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("MoneyAmount")) PlayerPrefs.SetInt("MoneyAmount", 500);
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        UpdateMoneyText();

        LocalPlantHandler = GameObject.Find("LokalPlantHandlerGO").GetComponent<lokalPlantHandler>();
        
        int plantType = LocalPlantHandler.getPlantType();
        int skin = LocalPlantHandler.getSkin();
        Debug.LogWarning("plantType = " + plantType);
        Debug.LogWarning("level= " + skin);

        if (plantType == 1)
        {
            ObjectToSpawn = PrefabPlantStagesPlantA[skin];
        }
        if (plantType == 2)
        {
            ObjectToSpawn = PrefabPlantStagesPlantB[skin];
        }
        if (plantType == 3)
        {
            ObjectToSpawn = PrefabPlantStagesPlantC[skin];
        }
        //  MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        //ObjectToSpawn = MotherTree.transfer_createGameObject();
        // MotherTree.createGameObject();
        //ObjectToSpawn = MotherTree.TreeDM;
        pm = FindObjectOfType<PlacementManager>();
    
      //  MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
       {
           
          GameObject visual = Instantiate(ObjectToSpawn, pm.transform.position, pm.transform.rotation);
       }
    }
    public void UpdateMoneyText() {
        Text moneyText = GameObject.Find("Canvas").transform.GetChild(1).transform.GetChild(1).gameObject.GetComponent<Text>();
        moneyText.text = moneyAmount.ToString();
    }
}
