using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Congrats : MonoBehaviour
{
    public Text goodJob;
    string[] Grats = new string[3];

    private void Start()
    {
        Grats[0] = "You can do it!";
        Grats[1] = "Good job!";
        Grats[2] = "Keep going!";
    }

    void OnTriggerEnter ()
    {
        foreach (string gj in Grats)
        {
            print(Grats);
        }
	}
}