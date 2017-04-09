using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aEffect : MonoBehaviour {

	public aEffect nextEffect;
	
	public virtual void PlayNextEffect()
	{
		if(nextEffect != null) nextEffect.enabled = true;
		enabled = false;
	}
	
	protected virtual void OnEnable(){}
}