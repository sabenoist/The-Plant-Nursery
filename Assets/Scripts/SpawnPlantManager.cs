﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IPlantInterface.cs;


public class SpawnPlantManager : MonoBehaviour
{
    private lokalPlantHandler LocalPlantHandler;
    public GameObject ObjectToSpawn;
    public PlacementManager pm;
    public GameObject[] PrefabPlantStagesPlantA;
    public GameObject[] PrefabPlantStagesPlantB;
    public GameObject[] PrefabPlantStagesPlantC;




    // Start is called before the first frame update
    void Start()
    {
        LocalPlantHandler = GameObject.Find("LokalPlantHandlerGO").GetComponent<lokalPlantHandler>();
        int plantType = LocalPlantHandler.getPlantType();
        int level = LocalPlantHandler.getLevel();
        Debug.LogWarning("plantType = " + plantType);
        Debug.LogWarning("level= " + level);

        if (plantType == 1)
        {
            ObjectToSpawn = PrefabPlantStagesPlantA[level];
        }
        if (plantType == 2)
        {
            ObjectToSpawn = PrefabPlantStagesPlantB[level];
        }
        if (plantType == 3)
        {
            ObjectToSpawn = PrefabPlantStagesPlantC[level];
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
}
