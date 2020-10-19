using IPlantInterface.cs;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Rendering;
using UnityEngine;

public class createObject : MonoBehaviour
{
    private GameObjectHandler MotherTree;
    // Start is called before the first frame update.
    void Start()
    {
        MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
    }

    public void createGameObject()
    {
        MotherTree.createGameObject();
    }
}