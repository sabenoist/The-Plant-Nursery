using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopTest : MonoBehaviour
{
    GameObject Item;
    GameObject g;
    [SerializeField] Transform ScrollView;

    void Start ()
    {
      Item = ScrollView.GetChild (0).gameObject;

      for  (int i = 0; i<10;i++)
       {
         g = Instantiate (Item, ScrollView);
        }

     Destroy (Item);
    }
}
