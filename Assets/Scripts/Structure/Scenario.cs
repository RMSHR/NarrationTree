using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenario : MonoBehaviour, iFindInChildren {

	public List<ScenarioPart> parts;
	
	void Awake() {
		FindInChildren();
	}
	
	public void FindInChildren()
	{
		ScenarioPart[] _parts = GetComponentsInChildren<ScenarioPart>();
		
		parts = new List<ScenarioPart>();
		
		foreach(ScenarioPart p in _parts)
		{
			parts.Add(p);
		}
	}
}
