using IPlantInterface.cs;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Test : MonoBehaviour
{
    private GameObjectHandler someScript;
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void testFunction()
    {
        someScript = GameObject.Find("MotherTree").GetComponent <GameObjectHandler> ();
        someScript.createPlant(1);
        someScript.createGameObject();
        someScript.toString();
       // someScript.
       // someScript.createGameObject();
    }

}
