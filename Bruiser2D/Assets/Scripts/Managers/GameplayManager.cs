using UnityEngine;
using System.Collections;

public class GameplayManager : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(GameManager.gamestatus != GameManager.Gamestatus.runningPlay)	
			return;

		// grab select plays, etc
	}
}
