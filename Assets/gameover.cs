using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour 
{
	void OnTriggerEnter(Collider other)
	{
		Application.LoadLevel ("GameOver");
	}
}
