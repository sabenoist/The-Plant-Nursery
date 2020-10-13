using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Plant : MonoBehaviour
{
    private string name;
    private bool isAlive;
    private bool isThirsty;
    private int moisturised; //(0-10)
    private int level; //(1-30)
    private int skin; //(1-3)

    public void initiatePlant (string name) //Could not call constructor from Unity, so made a work-a-round function. Sander pls dont be mad :/
    {
        this.name = name;
        moisturised = 6;
        level = 1;
        isThirsty = isThirstyFunction();
        isAlive = isAliveFunction();
        skin = whichSkin();
    }

    public bool isThirstyFunction()
    {
       return moisturised < 7;
    }   


    public bool isAliveFunction()
    {
        return moisturised <= 0;
    }

    public void watering()
    {
        moisturised++;
        level++;
    }

    public void dryening()
    {
        moisturised--;
    }

    public int whichSkin()
    {
        if (level < 10)
        {
            skin = 1;
        }
        if (level >= 10 && level < 20)
        {
            skin = 2;
        }
        if (level >= 20 )
        {
            skin = 3;
        }
        return skin;
    }   

    public void toString()
    {
        Debug.Log("name" + name);
    }

}
