using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDay : MonoBehaviour 
{
    public float timeOfDay = 2;
	void Update () 
	{
        //Rotates an object on a specified Vector.
		transform.Rotate (new Vector3 (timeOfDay, timeOfDay, 0.0f)* Time.deltaTime);
	}
}
