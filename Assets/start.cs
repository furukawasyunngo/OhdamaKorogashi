using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Application.LoadLevel ("StageSelect");
		}
	}
}
