using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[AddComponentMenu("Paint/Core/(abstract) Effect")]
public class aEffect : MonoBehaviour {
	
	protected virtual void Awake() {
		// Effect should not be active at the begining
		enabled = false;
	}
	
	public virtual void PlayEffect(){}
}