using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DefensivePlays : MonoBehaviour 
{
	//Current selection
	public static Play SelectedDefensivePlay;
	public static bool flag;

	public enum Formations
	{
		fourthree,
		threefour,
		dime
	}
	
	public enum Routes
	{
		spy,
		man,
		zone,
		insideblitz,
		outsideblitz,
		stunt1,
		stunt2
	}
	
	//struct for each play
	public struct Play
	{
		string[] _playerPos;
		Vector3[] _vectorPos;
		Routes[] _route;
		
		//getter and setter for playerpos, vectorpos and route
		public string[] PlayerPositions
		{
			get{return _playerPos;}
			set{_playerPos = value;}
		} 
		
		public Vector3[] VectorPosition
		{
			get{return _vectorPos;}
			set{_vectorPos = value;}
		}
		
		public Routes[] Routes
		{
			get{return _route;}
			set{_route = value;}
		}
	}
	
	//holds all possible plays per formation
	public List<Play> allPlays;
	// holds all formations, plays, pos, routes.	
	//public List<string, List<allPlays>>formations;
	
	public Dictionary<string, List<Play>> formations;
	
	// Use this for initialization
	void Start () 
	{
		#region Create playbook
		formations = new Dictionary<string, List<Play>>(2);
		#endregion
		
		#region Create plays
		// first play
		Play _p1 = new Play();
		
		_p1.VectorPosition = new Vector3[7];
		_p1.VectorPosition[0] = new Vector3(0	,0	,-12);//MLB
		_p1.VectorPosition[1] = new Vector3(0	,0	,-17);//SF
		_p1.VectorPosition[2] = new Vector3(-10	,0	,-7);//CB1
		_p1.VectorPosition[3] = new Vector3(10	,0	,-7);//CB2
		_p1.VectorPosition[4] = new Vector3(-5	,0	,-7);//DL1
		_p1.VectorPosition[5] = new Vector3(0	,0	,-7);//DL2
		_p1.VectorPosition[6] = new Vector3(5	,0	,-7);//DL3
		
		_p1.PlayerPositions = new string[7];
		_p1.PlayerPositions[0] = "MLB";
		_p1.PlayerPositions[1] = "SF";
		_p1.PlayerPositions[2] = "CB1";
		_p1.PlayerPositions[3] = "CB2";
		_p1.PlayerPositions[4] = "DL1";
		_p1.PlayerPositions[5] = "DL2";
		_p1.PlayerPositions[6] = "DL3";
		
		_p1.Routes = new Routes[7];
		_p1.Routes[0] = Routes.spy;
		_p1.Routes[1] = Routes.outsideblitz;
		_p1.Routes[2] = Routes.stunt1;
		_p1.Routes[3] = Routes.stunt2;
		_p1.Routes[4] = Routes.zone;
		_p1.Routes[5] = Routes.zone;
		_p1.Routes[6] = Routes.zone;
		
		
		//second play
		Play _p2 = new Play();
		
		_p2.VectorPosition = new Vector3[7];
		_p2.VectorPosition = _p1.VectorPosition;
		
		_p2.PlayerPositions = new string[7];
		_p2.PlayerPositions = _p1.PlayerPositions;
		
		_p2.Routes = new Routes[7];
		_p2.Routes[0] = Routes.zone;
		_p2.Routes[1] = Routes.zone;
		_p2.Routes[2] = Routes.zone;
		_p2.Routes[3] = Routes.zone;
		_p2.Routes[4] = Routes.zone;
		_p2.Routes[5] = Routes.zone;
		_p2.Routes[6] = Routes.zone;

		//third play
		Play _p3 = new Play();

		_p3.VectorPosition = new Vector3[7];
		_p3.VectorPosition = _p1.VectorPosition;

		_p3.PlayerPositions = new string[7];
		_p3.PlayerPositions = _p1.PlayerPositions;

		_p3.Routes = new Routes[7];
		_p3.Routes[0] = Routes.zone;
		_p3.Routes[1] = Routes.stunt1;
		_p3.Routes[2] = Routes.stunt2;
		_p3.Routes[3] = Routes.outsideblitz;
		_p3.Routes[4] = Routes.spy;
		_p3.Routes[5] = Routes.zone;
		_p3.Routes[6] = Routes.zone;
		#endregion
		
		#region collect all plays for particular formation 
		allPlays = new List<Play>();
		allPlays.Add(_p1);
		allPlays.Add(_p2);
		allPlays.Add(_p3);
		#endregion
		
		#region Add plays to formation 
		formations.Add(Formations.fourthree.ToString(), allPlays);
		#endregion
		
		// See whether formation contains this play.
		if (formations.ContainsKey(Formations.fourthree.ToString()))
		{
			List<Play> temp = formations[Formations.fourthree.ToString()];
			SelectedDefensivePlay = temp[2];//hack for selected play
		}
	}
}
