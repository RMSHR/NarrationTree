using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aEffect : MonoBehaviour {

	public aEffect nextEffect;
	
	protected virtual void Awake() {
		// Effect should not be active at the begining
		enabled = false;
	}
	
	public virtual void PlayEffect(){}
	
	public virtual void PlayNextEffect()
	{
		// active next, desactive self
		if(nextEffect != null) nextEffect.enabled = true;
		enabled = false;
	}
}