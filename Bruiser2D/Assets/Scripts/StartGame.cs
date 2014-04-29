using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using offensive = OffensivePlays;
using defensive = DefensivePlays;

public class StartGame : MonoBehaviour 
{

	//menus
	public List<GameObject> offensivePlayers;
	public List<GameObject> defensivePlayers;

	public GameObject ballPosition;

	//player team object holders
	GameObject offense;
	GameObject defense;

	// Use this for initialization
	void Start () 
	{	
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


		defense.transform.parent = ballPosition.transform;
		offense.transform.parent = ballPosition.transform;
		ballPosition.transform.position = GameManager.ballPostion;	
	}
	
	// Update is called once per frame
	public virtual void Update () {
		//Debug.Log("tick game manager");
	}
}
