using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	public class Branch : MonoBehaviour, iFindInChildren, iHasLabel {
		
		public string specificLabel = "";
		
		public int activationTime = -1;
		
		private int activationCounter = 0;
		
		protected List<aEffect> branchEffects;
		
		public void DefineLabel()
		{
			gameObject.name = "Branch "+specificLabel;
		}
		
		void Awake() {
			FindInChildren();
		}
		
		public void FindInChildren()
		{
			aEffect[] _effects = GetComponentsInChildren<aEffect>();
			
			branchEffects = new List<aEffect>();
			
			foreach(aEffect e in _effects)
			{
				branchEffects.Add(e);
			}
		}
		
		public void ActiveEffects() {
			if(!CanPlayEffect())
				return;
			
			foreach(aEffect effect in branchEffects)
			{
				effect.PlayEffect();
			}
		}
		
		// depends on limitNumber : can play unlimited time an effect or a precise number of time
		bool CanPlayEffect() {
			if(activationTime <= 0)
				return true;
			else
			{
				if(activationCounter < activationTime)
				{
					activationCounter++;
					return true;
				}
				else
					return false;
			}
		}
		
	}

}