using IPlantInterface.cs;
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
       // MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
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
        MotherTree.createPlant(plantType-1);
    }

    /*
     Destroys the activePlant from the MothersTree´s array.
    */
    public void destroyPlant()
    {
        MotherTree.destroyPlant();
    }

    /*
     Select a plant 1-3 to become the active plant. 
    */
    public void selectPlant(int activPlant)
    {
        MotherTree.selectPlant(activPlant-1);
    }
    /*
     Waters the active plant.
    */
    public void watering()
    {
        MotherTree.watering();
    }
    /*
     Dehydrates ALL the plants stored in the array with 10 %.
    */
    public void dryening()
    {
        MotherTree.dryening();
    }

    /*
     Returns the water lvl 0 to 100 %.
    */
    public int getWaterLevel()
    {
        return MotherTree.getWaterLevel();
    }

    /*
     Creates a new GAMEOBJECT into the UNITY SCENE. Only 1 at time allowed.
    */
    public void createGameObject()
    {
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
        MotherTree.Destroy();
    }

    /*
    Only used for debugging. Writes all of the plants in the MotherTree array attributes to the Unity console.
    */
    public void toString()
    {
        MotherTree.toString();
    }
}




