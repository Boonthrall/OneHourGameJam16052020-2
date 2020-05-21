using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDimensions : MonoBehaviour
{
    private GameObject[] red;
    private GameObject[] blue;
    private bool BlueIsActive = true;


    // Start is called before the first frame update
    void Start()
    {
       if(red == null)
       {
            getRedObjects();
       }
       if(blue == null)
       {
            getBlueObjects();
       }
    }

    private void OnMouseDown()
    {
        BlueIsActive = !BlueIsActive;

        if (BlueIsActive)
        {
            foreach(GameObject box in red)
            {
                box.SetActive(false);
            }
        }
        else
        {
            foreach(GameObject box in blue)
            {
                box.SetActive(false);
            }
        }
    }

    private void getRedObjects()
    {
        red = GameObject.FindGameObjectsWithTag("DimRed");
    }
    private void getBlueObjects()
    {
        blue = GameObject.FindGameObjectsWithTag("DimBlue");
    }
}
