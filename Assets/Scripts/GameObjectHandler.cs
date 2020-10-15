using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectHandler : MonoBehaviour
{
 
    private int amountOfPlants = 0;
    private int amountOfPlantA;
    private int amountOfPlantB;
    private int amountOfPlantC;

    public int activePlant;

    public GameObject Prefab_Plant_A;
    public GameObject Prefab_Plant_B;
    public GameObject Prefab_Plant_C;

    public GameObject[] Plants;

    // Start is called before the first frame update
    void Start()
    {
        Plants = new GameObject[4];
        activePlant = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createPlantA()
    {
        if(amountOfPlants < 3)
        {
            int i = 0;
           while(Plants[i] != null)
            {
                i++;
            }
            GameObject temp = Instantiate(Prefab_Plant_A);
            Plants[i] = temp;
            Plants[i].GetComponent<Plant>().initiatePlant("Plant_A_" + amountOfPlantA);
            amountOfPlants++;
            amountOfPlantA++;
        }       
    }

    public void createPlantB()
    {
        if (amountOfPlants < 3)
        {
            int i = 0;
            while (Plants[i] != null)
            {
                i++;
            }
            GameObject temp = Instantiate(Prefab_Plant_B);
            Plants[i] = temp;
            Plants[i].GetComponent<Plant>().initiatePlant("Plant_B_" + amountOfPlantB);
            amountOfPlants++;
            amountOfPlantB++;
        }
    }

    public void createPlantC()
    {
        if (amountOfPlants < 3)
        {
            int i = 0;
            while (Plants[i] != null)
            {
                i++;
            }
            GameObject temp = Instantiate(Prefab_Plant_C);
            Plants[i] = temp;
            Plants[i].GetComponent<Plant>().initiatePlant("Plant_C_" + amountOfPlantC);
            amountOfPlants++;
            amountOfPlantC++;
        }
    }

    public void selectPlant(int activPlant)
    {
        this.activePlant = activPlant;
    }

    
    public void watering()
    {
        Plants[activePlant].GetComponent<Plant>().watering();
    }

    public void dryening()
    {
        Plants[activePlant].GetComponent<Plant>().dryening();
    }

    public void destroy()
    {
        Destroy(Plants[activePlant]);
        Plants[activePlant] = null;
        amountOfPlants--;
    }

    public void toString()
    {
        int i = 0;
        while (Plants[i] != null)
        {
            Plants[i].GetComponent<Plant>().toString();
            i++;
        }
    }
}
