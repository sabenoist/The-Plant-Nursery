using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!MapData.mapExists) {
            MapData.mapExists = true;
        } else {
            Destroy(gameObject);  //prevent duplicate map upon return to main menu screen.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
