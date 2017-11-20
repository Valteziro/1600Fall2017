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

    void Awake ()
    {
        player = GameObject.Find ("Player").transform;
        agent = GetComponent <NavMeshAgent> ();
    }
	void FixedUpdate ()
	{
        if(!gameOver)
        {
            agent.destination = player.position;
        }
	}
}