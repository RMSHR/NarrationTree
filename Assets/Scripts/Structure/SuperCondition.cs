using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCondition : MonoBehaviour, iFindComponents, iFindInChildren, iTestCondition {

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
	
	public void ActiveFirstEffect()
	{
		effects[0].PlayEffect();
		effects[0].PlayNextEffect();
		
		// TODO : increment effect id to play
	}
	
	public void ActiveEffects() {
		foreach(aEffect effect in effects)
		{
			effect.PlayEffect();
		}
	}
}
