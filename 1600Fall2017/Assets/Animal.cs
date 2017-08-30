using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	// Use this for initialization
	public virtual void Start ()
    {	
		die();
		eat();
		sleep();    
	}
    
    //This makes stuff die
	void die ()
    {
		print(this.name + " dies");	
	}

    //This makes stuff eat
	void eat ()
    {
		print(this.name + " eats");		
	}

    //This makes stuff sleep
	void sleep ()
    {
		print(this.name + " sleeps");
	}

}

