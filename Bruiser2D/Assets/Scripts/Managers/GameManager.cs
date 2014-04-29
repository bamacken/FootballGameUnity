using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	public enum Gamestatus
	{
		playSelection,
		paused, 
		runningPlay,
		menu
	}

	public static Gamestatus gamestatus;
	public static Vector3 ballPostion;
	public static float time;

	void OnEnable () 
	{
		gamestatus = Gamestatus.playSelection;
		ballPostion = new Vector3(0,0,0);
		time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	void OnDisable()
	{
		ballPostion = new Vector3(0,0,0);
		time = 0.0f;
	}
}
