using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObjectBetweenScenes : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
