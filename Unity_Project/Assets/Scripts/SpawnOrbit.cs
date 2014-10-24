using UnityEngine;
using System.Collections;

public class SpawnOrbit : MonoBehaviour
{
	public GameObject[] Orbits ;
	public float MinWaitTime;
	public float MaxWaitTime;

	void Awake()
	{
		Spawn ();
	}

	void Spawn()
	{
		Instantiate(Orbits[Random.Range (0,Orbits.Length - 1)],transform.position, Quaternion.identity);
		Invoke ("Spawn", Random.Range (MinWaitTime,MaxWaitTime));
	}
}
