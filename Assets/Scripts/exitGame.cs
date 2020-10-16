using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class exitGame : MonoBehaviour
{
    public Canvas start;
    public Button exit;

    public void quit()
    {
        Application.Quit();
    }
}
