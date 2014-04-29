using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Routes : MonoBehaviour 
{
	List<Vector3> path;
	public Dictionary<OffensivePlays.Routes, List<Vector3>> RouteMapOffensive;
	public static Dictionary<OffensivePlays.Routes, List<Vector3>> staticOffensiveRouteMap;

	public Dictionary<DefensivePlays.Routes, List<Vector3>> RouteMapdefensive;
	public static Dictionary<DefensivePlays.Routes, List<Vector3>> staticDefensiveRouteMap;

	// Use this for initialization
	void Start () 
	{
		#region offensive routes
		
		RouteMapOffensive = new Dictionary<OffensivePlays.Routes, List<Vector3>>();

		//streak
		path = new List<Vector3>(1);
		path.Add(new Vector3(0, 0, 10));
		RouteMapOffensive.Add(OffensivePlays.Routes.streak, path);

		//upandin
		path = new List<Vector3>(2);
		path.Add(new Vector3(0, 0, 5));
		path.Add(new Vector3(-10, 0, 5));
		RouteMapOffensive.Add(OffensivePlays.Routes.upandin, path);

		//upandout
		path = new List<Vector3>(2);
		path.Add(new Vector3(0, 0, 5));
		path.Add(new Vector3(10, 0, 5));
		RouteMapOffensive.Add(OffensivePlays.Routes.upandout, path);

		//do at end store static copy of route map
		staticOffensiveRouteMap = RouteMapOffensive;
		#endregion
		
		#region defensive routes
		RouteMapdefensive = new Dictionary<DefensivePlays.Routes, List<Vector3>>();
		
		//streak
		path = new List<Vector3>(1);
		path.Add(new Vector3(0, 0, -10));
		RouteMapdefensive.Add(DefensivePlays.Routes.zone, path);

		staticDefensiveRouteMap = RouteMapdefensive;
		#endregion
	}
	static int i = 0;
	public static void GetRoute(OffensivePlays.Routes _route)
	{
		if(staticOffensiveRouteMap.ContainsKey(_route))
		{
			i++;
			//Debug.Log(_route.ToString());
		}
		//Debug.Log("count = " + i);
	}

	public static void GetRoute(DefensivePlays.Routes _route)
	{
		if(staticDefensiveRouteMap.ContainsKey(_route))
		{
			i++;
			//Debug.Log(_route.ToString());
		}
		//Debug.Log("count = " + i);
	}


}
