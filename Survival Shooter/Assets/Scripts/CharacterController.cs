using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterController : MonoBehaviour 
{
	public float speed = 5f;
	public static bool gameOver = false;
	Vector3 movement;
	Rigidbody playerRigidbody;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;

	void Awake ()
	{
		playerRigidbody = GetComponent<Rigidbody> ();
	}

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
	}

	void Move (float moveHorizontal, float moveVertical)
	{
		movement.Set (moveHorizontal, 0.0f, moveVertical);
		//Makes it so moving diagonally doesn't give you a speed boost.
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigidbody.MovePosition (transform.position + movement);		
	}
}