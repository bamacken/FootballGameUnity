using UnityEngine;
using System.Collections;

public class SelectionManager : MonoBehaviour {


	// Use this for initialization
	void Start () 
	{
//		OffensivePlays.SelectedOffensivePlay = "play type here";
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (GameManager.gamestatus != GameManager.Gamestatus.playSelection) 
			return;

		//logic here
	}
}
