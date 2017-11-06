using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter ()
    {
        ReplayGame.StartPosition = transform.position;
	}
}