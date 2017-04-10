using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCondition : aCondition {

	public enum KeyModeEnum {
		Down,
		Stay,
		Up
	};

	public KeyCode key;
	public KeyModeEnum keyMode = KeyModeEnum.Down;
	
	public override bool TestCondition()
	{
		bool test = false;
		
		switch(keyMode)
		{
			case KeyModeEnum.Down:
				test = Input.GetKeyDown(key);
				break;
				
			case KeyModeEnum.Stay:
				test = Input.GetKey(key);
				break;
				
			case KeyModeEnum.Up:
				test = Input.GetKeyUp(key);
				break;
		}
		
		return test;
	}
	
}
