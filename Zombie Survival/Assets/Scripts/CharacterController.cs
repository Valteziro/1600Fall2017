using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterController : MonoBehaviour 
{
	public static bool gameOver = false;
	public float speed;

	void FixedUpdate ()
	{
		//Assigns inputs for horizontal and vertical movement.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		//Assigns vector3 directions to the inputs above.
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		//Makes it so moving diagonally doesn't give you a speed boost.
		movement = movement.normalized;

		//Makes the movement dependant on the speed set in the inspector. 
		GetComponent<Rigidbody>().velocity = movement * speed;
	}
}