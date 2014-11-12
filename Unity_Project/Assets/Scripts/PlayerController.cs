using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float jumpSpeed;

	public int jumpTime;
	void Awake()
	{
		jumpTime = 0;
	} 
	void FixedUpdate()
	{
	   if(Input.GetKeyDown("space") && (jumpTime < 2 ))
		{
			rigidbody.velocity = (new Vector3(0f, jumpSpeed, 0f));
			jumpTime ++;
		}
		rigidbody.velocity = new Vector3 (speed, rigidbody.velocity.y, rigidbody.velocity.z);
	}
}
