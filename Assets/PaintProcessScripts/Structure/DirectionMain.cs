using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[AddComponentMenu("Paint/Structure/Direction Main")]
public class DirectionMain : MonoBehaviour, iFindInChildren {

	private int activePart = 0;
	protected List<DirectionPart> parts;
	
	// TODO : Singleton
	
	void Awake() {
		FindInChildren();
		
		foreach(DirectionPart part in parts)
		{
			part.gameObject.SetActive(false);
		}
		
		parts[activePart].gameObject.SetActive(true);
	}
	
	public void FindInChildren()
	{
		DirectionPart[] _parts = GetComponentsInChildren<DirectionPart>();
		
		parts = new List<DirectionPart>();
		
		foreach(DirectionPart p in _parts)
		{
			parts.Add(p);
		}
	}
	
	void Update() 
	{
		parts[activePart].TestCondition();
	}
	
	public void ChangePart(int _newPart)
	{
		activePart = _newPart;
	}
	
	public void NextPart(){
		activePart++;
	}
}
