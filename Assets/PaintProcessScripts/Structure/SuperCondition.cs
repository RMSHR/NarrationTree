using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[AddComponentMenu("Paint/Structure/Super Condition")]
public class SuperCondition : MonoBehaviour, iFindComponents, iFindInChildren, iTestCondition {

	public int limitNumber = -1;
	
	private int activationCounter = 0;

	protected List<aCondition> childConditions;
	
	protected List<aEffect> effects;
	
	void Awake() {
		FindComponents();
		FindInChildren();
	}
	
	public void FindComponents()
	{
		aCondition[] _conditions = GetComponents<aCondition>();
		
		childConditions = new List<aCondition>();
		
		foreach(aCondition c in _conditions)
		{
			childConditions.Add(c);
		}
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
	
	public bool TestCondition()
	{
		// if one child condition is false, return false
		foreach(aCondition c in childConditions)
		{
			if (!c.TestCondition())
				return false;
		}
		
		// if all conditions are true, return true
		return true;
	}
	
	public void ActiveEffects() {
		if(!CanPlayEffect())
			return;
		
		foreach(aEffect effect in effects)
		{
			effect.PlayEffect();
		}
	}
	
	// depends on limitNumber : can play unlimited time an effect or a precise number of time
	bool CanPlayEffect() {
		if(limitNumber <= 0)
			return true;
		else
		{
			if(activationCounter < limitNumber)
			{
				activationCounter++;
				return true;
			}
			else
				return false;
		}
	}
}
