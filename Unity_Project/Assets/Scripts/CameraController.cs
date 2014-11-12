using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
	public GameObject player;
	private Vector3 offSet;

	void Start()
	{
		offSet = transform.position;
		if(player == null)
		{
			player = GameObject.FindGameObjectWithTag("Player");
		}
	}

	void Update()
	{
		Vector3 temp = offSet + player.transform.position ;
		transform.position = new Vector3 (temp.x, offSet.y, temp.z);
	}
}
