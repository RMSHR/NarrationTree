using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCondition : MonoBehaviour {

	public enum KeyModeEnum {
		Down,
		Stay,
		Up
	};

	public KeyCode key;
	public KeyModeEnum keyMode = KeyModeEnum.Down;
	
	
	
}
