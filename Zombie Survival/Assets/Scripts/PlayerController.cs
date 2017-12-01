using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;    
	public CharacterController characterController;
    public static bool gameOver = false;
    public GameObject gameOverUI;

    private Vector3 movement;
	void Update()
    {
        //checks for gameOver, if gameOver is not true, the player can be controlled. If gameOver is true, the player cannot be controlled.
        if (!gameOver)
        {
            //assigns x and z movement to key tagged "Horizontal" and "Vertical" within Unity.
            movement.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }
        else
        {
            gameObject.SetActive(false);
        }
        //attaches this script to the characterController within Unity.
        characterController.Move(movement);
    }
    void OnTriggerEnter (Collider other) 
	{
        //searches for contact with gameObjects tagged "Healthkit"
		if(other.gameObject.CompareTag("Healthkit")) 
		{
            //Deactivates "Healthkit" on contact.
			other.gameObject.SetActive(false);
		}
	}
}