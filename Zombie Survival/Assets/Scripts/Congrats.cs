using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Congrats : MonoBehaviour
{
    public Text goodJob;
	
	void OnTriggerEnter ()
    {
        string[] Grats = { "You can do it!","Good job!","Keep going!" };
        foreach (string gj in Grats)
        {
            goodJob.text = (gj);
        }
	}
}