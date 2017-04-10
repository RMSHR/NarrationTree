using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectShowThis : aEffect {

	public GameObject gameObjectTarget;
	
	public PaintProcessEnums.ChangeBoolEnum newBoolState;
	
	public override void PlayEffect()
	{
		base.PlayEffect();
		
		bool newState = true;
		
		if(newBoolState == PaintProcessEnums.ChangeBoolEnum.SetFalse)
			newState = false;
		
		gameObjectTarget.SetActive(newState);
	}
}
