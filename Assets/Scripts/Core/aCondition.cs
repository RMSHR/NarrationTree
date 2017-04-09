using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class aCondition : MonoBehaviour, iFindInChildren {

	public enum ConditionOutEnum 
	{
		isBool,
		isConstFloat,
		isFromFloat
	}
	
	public ConditionOutEnum conditionOut = ConditionOutEnum.isBool;
	
	public List<aEffect> effects;
	
	protected virtual void Awake() 
	{
		FindInChildren();
	}
	
	public void FindInChildren()
	{
		aEffect[] _effects = GetComponentsInChildren<aEffect>();
		
		effects = new List<aEffect>();
		
		foreach(aEffect e in _effects)
		{
			effects.Add(e);
		}
	}
}
