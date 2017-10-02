using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{

    List<string> weapons = new Lists<string>();

    public void Start()
    {
        weapons.Add ("1911");
        weapons.Add ("Rhino");
        weapons.Add ("1887");
        weapons.Add ("M91/30");
        weapons.Add ("870");
        weapons.Add ("1860 Army");
        weapons.Add ("Single Action Army");
        weapons.Add ("Henry .22");
        weapons.Add ("AK-47");
        weapons.Add ("AA-15");

    }
    
}

