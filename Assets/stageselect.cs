using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageselect : MonoBehaviour 
{
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			Application.LoadLevel ("Game2");
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			Application.LoadLevel ("Game");
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) 
		{
			Application.LoadLevel ("Game3");
		}
	}
}
