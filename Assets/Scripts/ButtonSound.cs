using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource buttonSound;
    public AudioSource sellingSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSoundEffect()
    {
       buttonSound.Play();

    }

    public void playSellingSound()
    {
      sellingSound.Play();
    }
}
