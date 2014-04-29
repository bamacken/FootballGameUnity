using UnityEngine;
using System.Collections;
using route = Routes;

public class WR : MonoBehaviour 
{
	const int index = 2;

	//player speed
	float speed = 5.0f;
	//player position
	Vector3 pos;

	// Use this for initialization
	void Start () 
	{
		gameObject.GetComponent<PlayerClick>().menu = (CircularMenu)Resources.Load(transform.name.ToString(), typeof(CircularMenu));
		pos = transform.position;
		route.GetRoute(OffensivePlays.SelectedOffensivePlay.Routes[index]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
