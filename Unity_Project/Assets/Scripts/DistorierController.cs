using UnityEngine;
using System.Collections;

public class DistorierController : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			Application.LoadLevel(Application.loadedLevel);
			return;
		}

		Destroy (other.transform.parent.gameObject);
	}

}
