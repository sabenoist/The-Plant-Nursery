using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IPlantInterface.cs;


public class SpawnPlantManager : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public PlacementManager pm;
   
  

    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<PlacementManager>();
      //  MotherTree = GameObject.Find("MotherTree").GetComponent<GameObjectHandler>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
       {
           
          GameObject visual = Instantiate(ObjectToSpawn,pm.transform.position, pm.transform.rotation);
       }
    }
}
