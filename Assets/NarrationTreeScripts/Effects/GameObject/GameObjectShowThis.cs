using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	public class GameObjectShowThis : aEffect {

		public GameObject gameObjectTarget;
		
		public NarrationTreeEnums.ChangeBoolEnum newBoolState;
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			bool newState = true;
			
			if(newBoolState == NarrationTreeEnums.ChangeBoolEnum.SetFalse)
				newState = false;
			
			gameObjectTarget.SetActive(newState);
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect GameObject Show "+gameObjectTarget;
		}
	}

}