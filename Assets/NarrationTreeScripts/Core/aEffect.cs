using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	[DisallowMultipleComponent]
	[AddComponentMenu("Paint/Core/(abstract) Effect")]
	public class aEffect : MonoBehaviour, iHasLabel {
		
		public virtual void DefineLabel()
		{
			
		}
		
		protected virtual void Awake() {
			// Effect should not be active at the begining
			enabled = false;
		}
		
		
		
		public virtual void PlayEffect(){}
	}
}