using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using offensive = OffensivePlays;
using defensive = DefensivePlays;

public class StartGame : MonoBehaviour 
{
	public static StartGame startgame;


	//menus
	public List<GameObject> offensivePlayers;
	public List<GameObject> defensivePlayers;

	public  GameObject ballPosition;

	//player team object holders
	 public GameObject offense;
	 public GameObject defense;

	public void refreshOffense()
	{
		//must delete old list first
		for(int i = 0; i < 11; i++)
		{	
	/*		GameObject playerPrefab = offensivePlayers.Find(obj => obj.name == offensive.SelectedOffensivePlay.PlayerPositions[i].ToString());
			GameObject _player = (GameObject)Instantiate(playerPrefab,offensive.SelectedOffensivePlay.VectorPosition[i],Quaternion.identity);
			_player.transform.position = offensive.SelectedOffensivePlay.VectorPosition[i];
			_player.transform.parent = offense.transform;
			_player.name = offensive.SelectedOffensivePlay.PlayerPositions[i];
			Destroy();
	*/	}
		for(int i = 0; i < 11; i++)
		{
			GameObject playerPrefab = offensivePlayers.Find(obj => obj.name == offensive.SelectedOffensivePlay.PlayerPositions[i].ToString());
			GameObject _player = (GameObject)Instantiate(playerPrefab,offensive.SelectedOffensivePlay.VectorPosition[i],Quaternion.identity);
			_player.transform.position = offensive.SelectedOffensivePlay.VectorPosition[i];
			_player.transform.parent = offense.transform;
			_player.name = offensive.SelectedOffensivePlay.PlayerPositions[i];
		}
	}

	// Use this for initialization
	void Start () 
	{
		startgame = gameObject.GetComponent<StartGame>();

		offense = new GameObject("offense");
		defense = new GameObject("defense");
		ballPosition = new GameObject("ball");
		// grab and place the offensive players based on position and formation
		for(int i = 0; i < 11; i++)
		{
			GameObject playerPrefab = offensivePlayers.Find(obj => obj.name == offensive.SelectedOffensivePlay.PlayerPositions[i].ToString());
			GameObject _player = (GameObject)Instantiate(playerPrefab,offensive.SelectedOffensivePlay.VectorPosition[i],Quaternion.identity);
			_player.transform.position = offensive.SelectedOffensivePlay.VectorPosition[i];
			_player.transform.parent = offense.transform;
			_player.name = offensive.SelectedOffensivePlay.PlayerPositions[i];
		}
		/*
		//grab and place the defensive players based on position and formation
		for(int i = 0; i < 11; i++)
		{
			GameObject playerPrefab = defensivePlayers.Find(obj => obj.name == defensive.SelectedDefensivePlay.PlayerPositions[i].ToString());
			GameObject _player = (GameObject)Instantiate(playerPrefab, defensive.SelectedDefensivePlay.VectorPosition[i],Quaternion.identity);
			_player.transform.position = defensive.SelectedDefensivePlay.VectorPosition[i];
			_player.transform.parent = defense.transform;
			_player.name = defensive.SelectedDefensivePlay.PlayerPositions[i];
		}
*/	
		defense.transform.parent = ballPosition.transform;
		offense.transform.parent = ballPosition.transform;
		ballPosition.transform.position = GameManager.ballPostion;
	}
	
	// Update is called once per frame
	public virtual void Update () {
		//Debug.Log("tick game manager");
	}
}
