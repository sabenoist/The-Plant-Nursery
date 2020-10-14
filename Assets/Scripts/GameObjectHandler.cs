using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectHandler : MonoBehaviour
{
 
    public GameObject myPrefab;
    private int maxAmount = 0;
    GameObject Plant_1;
    Plant TheScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void createPlant()
    {
        if(maxAmount < 3)
        {
           Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }       
    }

    public void watering()
    {
        Plant_1 = GameObject.Find("Plant1");
        TheScript = Plant_1.GetComponent<Plant>();
        TheScript.watering();
        TheScript.toString();
    }
}
