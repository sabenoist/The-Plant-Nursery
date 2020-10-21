using IPlantInterface.cs;
using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Rendering;
using UnityEngine;

public class lokalPlantHandler: MonoBehaviour
{
    private GameObjectHandler MotherTree;
    // Start is called before the first frame update.
    void Start()
    {
        //MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
    }

    // Update is called once per frame.
    void Update()
    {
        
    }

    /*
       Creates a new plantObject into the array if possible. Planttype decides the planttype. Use 1-3.
    */     
    public void createPlant(int plantType)
    {
        Debug.LogWarning("Hello, World from lokal plantHandler");
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        MotherTree.createPlant(plantType-1);
    }

    /*
     Destroys the activePlant from the MothersTree´s array.
    */
    public void destroyPlant()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        MotherTree.destroyPlant();
    }

    /*
     Select a plant 1-3 to become the active plant. 
    */
    public void selectPlant(int activPlant)
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        MotherTree.selectPlant(activPlant);
    }
    /*
     Waters the active plant.
    */
    public void watering()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        MotherTree.watering();
    }
    /*
     Dehydrates ALL the plants stored in the array with 10 %.
    */
    public void dryening()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        MotherTree.dryening();
    }

    public bool isThirstyFunction()
    {
        return MotherTree.isThirstyFunction();

    }


    /*
     Returns the water lvl 0 to 100 %.
    */
    public int getWaterLevel()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        return MotherTree.getWaterLevel();
    }
    public int getPlantType()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        return MotherTree.getPlantType();
    }

    public int getLevel()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        return MotherTree.getLevel();
    }

    public int getSkin()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        return MotherTree.getSkin();
    }

    /*
     * Fertilizes the plant, increases its level by 10.
     */
    public void fertilize() {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();

        while (MotherTree.isThirstyFunction()) {
            MotherTree.watering();
        }

        MotherTree.fertilize();
    }

    /*
     Creates a new GAMEOBJECT into the UNITY SCENE. Only 1 at time allowed.
    */
    public void createGameObject()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        MotherTree.createGameObject();
    }
    /*
    public GameObject transfer_createGameObject()
    {
        MotherTree.createGameObject();
        return TreeDM;
    }
    */
    /*
     Destroys the GAMEOBJECT in unity.
    */
    public void DestroyGameObject()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        MotherTree.Destroy();
    }

    /*
    Only used for debugging. Writes all of the plants in the MotherTree array attributes to the Unity console.
    */
    public void toString()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        MotherTree.toString();
    }

    /*
     * Keeps the hardcoded mess from crashing.
     */
    public bool plantExists() {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
        return (MotherTree.plantExists());
    }
}




