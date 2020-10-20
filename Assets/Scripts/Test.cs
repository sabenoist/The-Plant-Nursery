using IPlantInterface.cs;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Rendering;
using UnityEngine;

public class Test : MonoBehaviour
{
    private GameObjectHandler MotherTree;
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void testFunction()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent <GameObjectHandler> ();
        MotherTree.createPlant(1);
        MotherTree.createGameObject();
        MotherTree.toString();
       // someScript.
       // someScript.createGameObject();
    }

}
