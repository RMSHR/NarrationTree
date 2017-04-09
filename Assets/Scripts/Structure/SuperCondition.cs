using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCondition : MonoBehaviour, iFindInChildren {

	public List<aCondition> childConditions;
	
	void Awake() {
		FindInChildren();
	}
	
	public void FindInChildren()
	{
		aCondition[] _conditions = GetComponentsInChildren<aCondition>();
		
		childConditions = new List<aCondition>();
		
		foreach(aCondition c in _conditions)
		{
			childConditions.Add(c);
		}
	}
}
