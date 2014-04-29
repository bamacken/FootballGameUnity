using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(GameManager.gamestatus != GameManager.Gamestatus.paused)	
			return;

		// pause logic here (menu)
	}
}
