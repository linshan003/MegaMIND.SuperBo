﻿using UnityEngine;
using System.Collections;

public class RoadController : MonoBehaviour 
{
    private GameObject player;

	void Awake()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnTriggerStay(Collider other)
	{
		if(other.gameObject == player)
		{
			player.GetComponent<PlayerController>().jumpTime = 0;
		}
	}
}
