using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateShop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("example")) PlayerPrefs.SetInt("example", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
