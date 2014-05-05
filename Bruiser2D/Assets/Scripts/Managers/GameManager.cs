using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using offensive = OffensivePlays;
using Play = OffensivePlays.Play;
using start = StartGame;

public class GameManager : MonoBehaviour 
{
	StartGame game;
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

	void Awake()
	{
		game = StartGame.startgame;
		//Debug.Log(theCamera);
		//Debug.Log(startgame);
		
	}
	void OnEnable () 
	{
		gamestatus = Gamestatus.playSelection;
		ballPostion = new Vector3(0,0,0);
		time = 0.0f;
		float _ScreenWidth = (Screen.width/100);
		float _ScreenHeight = (Screen.height/100);
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
	void ChangePlayPlus(int j)
	{
		offensive.playNum = offensive.playNum++;
		StartGame.startgame.refreshOffense();		
		print(offensive.playNum);
	}

	void ChangePlayMinus(int j)
	{
		offensive.playNum = offensive.playNum--;
		StartGame.startgame.refreshOffense();
		print(offensive.playNum);
	}
	
	void changeFormationPlus()
	{
		
	}
	void changeFormationMinus()
	{
		
	}
	/*void OnGUI()
	{
		if(gamestatus == Gamestatus.playSelection)
		{
			//List<Play> temp = formations[Formations.iformation.ToString()];
			// Make a background box
			GUI.Box(new Rect(10,10,100,90), "Formations");
		
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			if(GUI.Button(new Rect(20,40,80,20), "IFormation")) {
				offensive.playNum = 5;
				StartGame.startgame.refreshOffense();
				print("offense Changed");
				//List<OffensivePlays.Play> temp;
				//temp = OffensivePlays.Formations[offensive.Formations.iformation.ToString()];
				//offensive.SelectedOffensivePlay = temp[0];
			}
		
			// Make the second button.
			if(GUI.Button(new Rect(20,70,80,20), "ShotGunMax")) {
				//offensive.SelectedOffensivePlay = temp[5];
			}
		}
	}*/
}
