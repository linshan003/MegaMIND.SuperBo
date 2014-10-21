using UnityEngine;
using System.Collections;

public class RoadController : MonoBehaviour 
{
	public GameObject player;

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject == player)
		{
			player.GetComponent<PlayerController>().jumpTime = 0;
		}
	}
}
