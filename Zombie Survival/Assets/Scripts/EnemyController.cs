using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour 
{
    public static bool gameOver = false;
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
	void FixedUpdate ()
	{
        //If it isn't a game over, the enemy tracks and moves towards the players location.
        if(!gameOver)
        {
            agent.destination = player.position;
        }
        //(DOES NOT WORK.) If it is a game over, enemy stands still. 
       void OnTriggerExit ()
        {
            EnemyNavMeshAgent.myTarget = this.gameObject;
        }
	}
}