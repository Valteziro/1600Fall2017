using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnScript : MonoBehaviour
{
	public GameObject Enemy;
	public int hazardCount = 1;
	public float spawnWait = 0.5f;
	public float startWait = 1;
	public float waveWait = 5;            
	public Transform[] spawnPoints; 

	void Start ()
	{
		StartCoroutine(SpawnWaves ());
	}
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				int spawnPointIndex = Random.Range (0, spawnPoints.Length);
				Instantiate (Enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}