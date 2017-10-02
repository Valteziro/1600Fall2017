using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{

    string[] weapons = new string[10];

    public void Start()
    {
        weapons[0] = "1911";
        weapons[1] = "Rhino";
        weapons[2] = "1887";
        weapons[3] = "M91/30";
        weapons[4] = "870";
        weapons[5] = "1860 Army";
        weapons[6] = "Single Action Army";
        weapons[7] = "Henry .22";
        weapons[8] = "AK-47";
        weapons[9] = "AA-15";

        //Foreach pulls and prints each item in the list until the entire list has been printed to console.

        foreach (string weapon in weapons)
        {
            print (weapon);
        }

    }
    
}

