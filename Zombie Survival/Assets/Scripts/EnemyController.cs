using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour 
{
    public NavMeshAgent agent;
    public Transform player;

    void Awake ()
    {
        player = GameObject.Find ("Player").transform;
        agent = GetComponent <NavMeshAgent> ();
    }
	void Update ()
	{
        agent.destination = player.position;
	}
}