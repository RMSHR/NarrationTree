using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	[DisallowMultipleComponent]
	[AddComponentMenu("Paint/Structure/Direction Main")]
	public class DirectionMain : MonoBehaviour, iFindInChildren, iHasLabel {

		private int activePart = 0;
		protected List<DirectionPart> parts;
		
		public void DefineLabel()
		{
			gameObject.name = "Direction Main";
		}

		
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
			parts[activePart].gameObject.SetActive(false);
			
			activePart = _newPart;
			
			parts[activePart].gameObject.SetActive(true);
		}
		
		public void NextPart()
		{
			ChangePart(activePart + 1);
		}
	}
}
