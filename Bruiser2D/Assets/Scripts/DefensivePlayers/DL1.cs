﻿using UnityEngine;
using System.Collections;
using route = Routes;

public class DL1 : MonoBehaviour {

	const int index = 4;
	
	//player speed
	float speed = 5.0f;
	//player position
	Vector3 pos;
	
	// Use this for initialization
	void Start () 
	{
		pos = transform.position;
		route.GetRoute(DefensivePlays.SelectedDefensivePlay.Routes[index]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
