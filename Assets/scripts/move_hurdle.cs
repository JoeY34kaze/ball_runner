﻿using UnityEngine;
using System.Collections;

public class move_hurdle : MonoBehaviour {
	public float speed = 1.0f;
	// Use this for initialization
	void Start () {
	
	}

	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, -speed*Time.deltaTime);
	}
}
