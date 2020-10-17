using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IPlantInterface.cs
{


    public class GameObjectHandler : MonoBehaviour
    {
 
        private int amountOfPlants = 0;
        public int activePlant;

        public Sprite IconPlantA;
        public Sprite IconPlantB;
        public Sprite IconPlantC;

        public GameObject[] PrefabPlantStagesPlantA;
        public GameObject[] PrefabPlantStagesPlantB;
        public GameObject[] PrefabPlantStagesPlantC;
        IPI[] ArrayOfPlants;
        private GameObject TreeDM;

        // Start is called before the first frame update
        void Start()
        {
            ArrayOfPlants = new IPI[3];
            activePlant = 0;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void createPlant(int plantType)
        {
            if(amountOfPlants < 3)
            {
                int i = 0;
                 while(ArrayOfPlants[i] != null)
                {
                    i++;
                }
                ArrayOfPlants[i] = new Plant { };
                ArrayOfPlants[i].initiatePlant("Plant_" + amountOfPlants +"_"+ plantType, plantType);
                amountOfPlants++;
            }       
        }

        public void destroyPlant()
        {
            if(ArrayOfPlants[activePlant] != null)
            {
                ArrayOfPlants[activePlant] = null;
                amountOfPlants--;
            }
        }

        public void selectPlant(int activPlant)
        {
            this.activePlant = activPlant;
        }

        public void watering()
        {
            ArrayOfPlants[activePlant].watering();
        }

        public void dryening()
        {    
            int i = 0;
            while (i < 3)
            {
                if (ArrayOfPlants[i] != null)
                {
                    ArrayOfPlants[i].dryening();
                }
                i++;
            }
        }

        public int getWaterLevel()
        {
            return (ArrayOfPlants[activePlant].getMoisturised() * 10);
        }

        public void createGameObject()
        {
            DestroyGameObject();
            int skin = ArrayOfPlants[activePlant].getSkin();
            int plantType = ArrayOfPlants[activePlant].getPlantType();
            if (plantType == 0)
            {
                TreeDM = Instantiate(PrefabPlantStagesPlantA[skin]);
            }
            if (plantType == 1)
            {
                TreeDM = Instantiate(PrefabPlantStagesPlantB[skin]);
            }
            if (plantType == 2)
            {
                TreeDM = Instantiate(PrefabPlantStagesPlantC[skin]);
            }
        }

        public void DestroyGameObject()
        {
            Destroy(TreeDM);
        }

        public void toString()
        {
            int i = 0;
            while (i < 3)
            {
                if(ArrayOfPlants[i] != null)
                {
                    ArrayOfPlants[i].toString();
                }              
                i++;
            }
        }
    }
}
