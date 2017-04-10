using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectShowAmong : aEffect {

	public List<GameObject> gameObjectList;
	public int gameObjectTarget;
	
	public PaintProcessEnums.ChangeBoolEnum newBoolState;
	
	public override void PlayEffect()
	{
		base.PlayEffect();
		
		if(gameObjectList == null)
			return;
		
		bool newState = true;
		
		if(newBoolState == PaintProcessEnums.ChangeBoolEnum.SetFalse)
			newState = false;
		
		foreach(GameObject g in gameObjectList)
		{
			g.SetActive(!newState);
		}
		
		gameObjectList[gameObjectTarget].SetActive(newState);
		
	}
}
