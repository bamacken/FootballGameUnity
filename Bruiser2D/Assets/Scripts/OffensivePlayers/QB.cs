﻿using UnityEngine;
using System.Collections;
using route = Routes;

public class QB : MonoBehaviour {

	const int index = 0;
	
	//player speed
	float speed = 5.0f;
	//player position
	Vector3 pos;
	
	// Use this for initialization
	void Start () 
	{
		pos = transform.position;
		route.GetRoute(OffensivePlays.SelectedOffensivePlay.Routes[index]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
