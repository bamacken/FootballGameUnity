using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OffensivePlays : MonoBehaviour 
{
	//Current selection
	public static Play SelectedOffensivePlay;

	public enum Formations
	{
		strong,
		shotgun,
		iformation,
		singleback,
		spread
	}

	public enum Routes
	{
		qb,
		qbrun,
		hbrun,
		passblock,
		runblock,
		flat,
		slant5,
		slant10,
		flag,
		post,
		streak,
		upandin,
		upandout
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

		/* 
		/positions are in screen space from 0.0 to 1.0, 
		where 0.0 x and 0.0 y are top left 
		and 1.0 x and 1.0 y is bottom right 
		*/
		_p1.VectorPosition = new Vector3[11];
		_p1.VectorPosition[0]  = new Vector3( 0.5f,0.55f,0);//QB
		_p1.VectorPosition[1]  = new Vector3( 0.5f,0.6f,0);//FB
		_p1.VectorPosition[2]  = new Vector3( 0.5f,.65f,0);//HB
		_p1.VectorPosition[3]  = new Vector3( 0.5f,0.5f,0);//C
		_p1.VectorPosition[4]  = new Vector3(0.45f,0.5f,0);//G
		_p1.VectorPosition[5]  = new Vector3(0.55f,0.5f,0);//G
		_p1.VectorPosition[6]  = new Vector3( 0.6f,0.5f,0);//T
		_p1.VectorPosition[7]  = new Vector3( 0.4f,0.5f,0);//T
		_p1.VectorPosition[8]  = new Vector3(0.65f,0.5f,0);//TE
		_p1.VectorPosition[9]  = new Vector3(0.15f,0.5f,0);//WR
		_p1.VectorPosition[10] = new Vector3(0.85f,.55f,0);//WR
		  
		_p1.PlayerPositions = new string[11];
		_p1.PlayerPositions[0]  = "QB";
		_p1.PlayerPositions[1]  = "FB";
		_p1.PlayerPositions[2]  = "HB";
		_p1.PlayerPositions[3]  = "C";
		_p1.PlayerPositions[4]  = "G";
		_p1.PlayerPositions[5]  = "G";
		_p1.PlayerPositions[6]  = "T";
		_p1.PlayerPositions[7]  = "T";
		_p1.PlayerPositions[8]  = "TE";
		_p1.PlayerPositions[9]  = "WR";
		_p1.PlayerPositions[10] = "WR";
		  
		_p1.Routes = new Routes[11];
		_p1.Routes[0]  = Routes.qb;
		_p1.Routes[1]  = Routes.passblock;
		_p1.Routes[2]  = Routes.flat;
		_p1.Routes[3]  = Routes.post;
		_p1.Routes[4]  = Routes.passblock;
		_p1.Routes[5]  = Routes.passblock;
		_p1.Routes[6]  = Routes.passblock;
		_p1.Routes[7]  = Routes.passblock;
		_p1.Routes[8]  = Routes.passblock;
		_p1.Routes[9]  = Routes.passblock;
		_p1.Routes[10] = Routes.passblock;


		//second play
		Play _p2 = new Play();
		
		_p2.VectorPosition = new Vector3[7];
		_p2.VectorPosition = _p1.VectorPosition;

		_p2.PlayerPositions = new string[7];
		_p2.PlayerPositions = _p1.PlayerPositions;
		
		_p2.Routes = new Routes[7];
		_p2.Routes[0] = Routes.qb;
		_p2.Routes[1] = Routes.hbrun;
		_p2.Routes[2] = Routes.flat;
		_p2.Routes[3] = Routes.post;
		_p2.Routes[4] = Routes.runblock;
		_p2.Routes[5] = Routes.runblock;
		_p2.Routes[6] = Routes.runblock;

		//third play
		Play _p3 = new Play();

		_p3.VectorPosition = new Vector3[7];
		_p3.VectorPosition = _p1.VectorPosition;

		_p3.PlayerPositions = new string[7];
		_p3.PlayerPositions = _p1.PlayerPositions;
		
		_p3.Routes = new Routes[7];
		_p3.Routes[0] = Routes.runblock;
		_p3.Routes[1] = Routes.runblock;
		_p3.Routes[2] = Routes.streak;
		_p3.Routes[3] = Routes.runblock;
		_p3.Routes[4] = Routes.runblock;
		_p3.Routes[5] = Routes.runblock;
		_p3.Routes[6] = Routes.runblock;
		#endregion

		#region collect all plays for particular formation 
		allPlays = new List<Play>();
		allPlays.Add(_p1);
		allPlays.Add(_p2);
		allPlays.Add(_p3);
		#endregion

		#region Add plays to formation 

		//loop throught all formations and add them into the formatiosn dictionary 
		if(!formations.ContainsKey(Formations.iformation.ToString()))
		{
			formations.Add(Formations.iformation.ToString(), allPlays);
		}
		#endregion

		// See whether formation contains this play.
		if (formations.ContainsKey(Formations.iformation.ToString()))
		{
			List<Play> temp = formations[Formations.iformation.ToString()];
			SelectedOffensivePlay = temp[2]; //hack for selected play
		}
	}
}
