﻿using UnityEngine;
using System.Collections;

public class selectionGlow : MonoBehaviour 
{
    public float speed = 0.1f;

	void Update () 
    {
        transform.eulerAngles += new Vector3(0, speed, 0);
	}
}
