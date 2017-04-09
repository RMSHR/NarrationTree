using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioPart : MonoBehaviour, iFindInChildren {

	public List<SuperCondition> superConditions;
	
	void Awake() {
		FindInChildren();
	}
	
	public void FindInChildren()
	{
		SuperCondition[] _superConditions = GetComponentsInChildren<SuperCondition>();
		
		superConditions = new List<SuperCondition>();
		
		foreach(SuperCondition s in _superConditions)
		{
			superConditions.Add(s);
		}
	}
}
