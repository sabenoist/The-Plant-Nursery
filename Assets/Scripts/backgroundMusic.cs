using UnityEngine;
using System.Collections;
 
 public class backgroundMusic : MonoBehaviour
 {
 
     private static backgroundMusic instance = null;
     public static backgroundMusic Instance
     {
         get { return instance; }
     }
     void Awake()
     {
         if (instance != null && instance != this) {
             Destroy(this.gameObject);
             return;
         } else {
             instance = this;
         }
         DontDestroyOnLoad(this.gameObject);
     }
}