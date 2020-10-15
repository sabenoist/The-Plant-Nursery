using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Plant : MonoBehaviour
{
    private string name;
    private int moisturised; //(0-10)
    private int level; //(1-30)


    public void initiatePlant (string name) //Could not call constructor from Unity, so made a work-a-round function. Sander pls dont be mad :/
    {
        this.name = name;
        moisturised = 5;
        level = 1;
    }

    public bool isThirstyFunction()
    {
       return moisturised < 6;
    }   


    public bool isAliveFunction()
    {
        return moisturised >= 0;
    }

    public void watering()
    {
        if(isAliveFunction() && moisturised < 10) //Can only moisturise if not dead and not fully satisfied
        {
            moisturised++;
            if(!isThirstyFunction()) //Can only grow if not thirsty
            {
                level++;
            }
        }
    }

    public void dryening()
    {
        moisturised--;
    }

    public int whichSkin() 
    {
        int skin = 0; //Annoying warning if not initiated
        if (level <= 0)
        {
            skin = 0;
        }
        if (level >= 1 && level < 10)
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

    public void setName(string name)
    {
        this.name = name;
    }

    public void toString()
    {
        string DebugString = "name: " + name + System.Environment.NewLine + "Alive: " + isAliveFunction() + System.Environment.NewLine;
        DebugString += "Thirsty: " + isThirstyFunction() + System.Environment.NewLine + "moisture " + moisturised + System.Environment.NewLine;
        DebugString += "Level: " + level + System.Environment.NewLine + "Skin: " + whichSkin();

        Debug.Log(DebugString);
    }

    public string getName()
    {
        return name;
    }

    public int getMoisture()
    {
        return moisturised;
    }

    public int getLevel()
    {
        return level;
    }

}
