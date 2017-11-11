using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterController : MonoBehaviour 
{
	public static bool gameOver = false;
	public Rigidbody playerRigidbody;
	public float speed;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;

	void Update ()
	{
		if (Input.GetButton("Jump") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			GetComponent<AudioSource>().Play ();
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");

		Quaternion newRotation = Quaternion.LookRotation (Input.mousePosition);
		playerRigidbody.MoveRotation (newRotation);

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		//Makes it so moving diagonally doesn't give you a speed boost.
		movement = movement.normalized;
		//Makes the movement dependant on the speed set in the inspector. 
		GetComponent<Rigidbody>().velocity = movement * speed;
	}
}