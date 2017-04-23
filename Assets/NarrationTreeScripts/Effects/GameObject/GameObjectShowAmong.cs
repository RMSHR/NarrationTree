using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
		
	public class GameObjectShowAmong : aEffect {

		public List<GameObject> gameObjectList;
		public int gameObjectTarget;
		
		public NarrationTreeEnums.ChangeBoolEnum newBoolState;
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			if(gameObjectList == null)
				return;
			
			bool newState = true;
			
			if(newBoolState == NarrationTreeEnums.ChangeBoolEnum.SetFalse)
				newState = false;
			
			foreach(GameObject g in gameObjectList)
			{
				g.SetActive(!newState);
			}
			
			gameObjectList[gameObjectTarget].SetActive(newState);
			
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect GameObject Show "+gameObjectTarget+" Among";
		}
	}

}
