using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionPart : MonoBehaviour, iFindInChildren, iTestCondition {

	protected List<SuperCondition> superConditions;
	
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
	
	public bool TestCondition()
	{
		foreach(SuperCondition superCondition in superConditions)
		{
			if(superCondition.TestCondition())
				superCondition.ActiveEffects();
		}
		
		return true;
	}
}
