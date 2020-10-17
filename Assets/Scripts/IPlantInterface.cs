using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

namespace IPlantInterface.cs
{
    interface IPI 
    {
        
        string getName();
        int getMoisturised();
        int getLevel();
        int getSkin();
        int getPlantType();
        void initiatePlant(string input, int input2);
        bool isThirstyFunction();
        bool isAliveFunction();
        void watering();
        void dryening();
        int whichSkin();
        void toString();
    }
}
