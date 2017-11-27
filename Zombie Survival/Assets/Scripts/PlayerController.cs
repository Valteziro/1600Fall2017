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
        if (!gameOver)
        {
            movement.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }
        characterController.Move(movement);
    }
    void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.CompareTag("Healthkit")) 
		{
			other.gameObject.SetActive(false);
		}
	}
}