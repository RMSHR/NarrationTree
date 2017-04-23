using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
		
	[DisallowMultipleComponent]
	[AddComponentMenu("Paint/Structure/Direction Part")]
	public class DirectionPart : MonoBehaviour, iFindInChildren, iTestCondition, iHasLabel {

		protected List<SuperCondition> superConditions;
		
		public void DefineLabel()
		{
			gameObject.name = "Direction Part";
		}
		
		void Awake() {
			FindInChildren();
		}
		
		public void FindInChildren()
		{
			SuperCondition[] _superConditions = GetComponentsInChildren<SuperCondition>();
			
			superConditions = new List<SuperCondition>();
			
			foreach(SuperCondition s in _superConditions)
			{
				superConditions.Add(s);
			}
		}
		
		public bool TestCondition()
		{
			foreach(SuperCondition superCondition in superConditions)
			{
				if(superCondition.TestCondition())
					superCondition.ActiveBranchEffects();
			}
			
			return true;
		}
	}

}
