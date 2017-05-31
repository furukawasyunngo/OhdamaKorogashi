using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameclear : MonoBehaviour 
{
	public GameObject Sphere;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Sphere") 
		{
			Application.LoadLevel ("GameClear");
		}
	}
}
