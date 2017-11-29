using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour 
{
    public NavMeshAgent agent;
    public Transform player;
    public Transform Zombie;

    void Awake ()
    {
        //Locates player game object automatically.
        player = GameObject.Find ("Player").transform;
        //Locates the NavMesh.
        agent = GetComponent <NavMeshAgent> ();
    }
	void Update ()
	{
        //If it isn't a game over, the enemy tracks and moves towards the players location.
        if(!PlayerController.gameOver)
        {
            agent.destination = player.position;
        }
        //If it is a game over, enemy stands still. 
        if(PlayerController.gameOver)
        {
            agent.destination = transform.position;
        }
	}
}