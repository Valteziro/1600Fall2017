using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congrats : MonoBehaviour
{
    public Text goodJob;
	
	void Update ()
    {
        string[] Grats = { "You can do it!","Good job!","Keep going!" };
        foreach (string gj in Grats)
        {
            goodJob.text = ("{0} ", gj);
        }
	}
}
