﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startscene : MonoBehaviour 
{
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel("Title");
		}
	}
}
