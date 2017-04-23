using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
		
	[DisallowMultipleComponent]
	[AddComponentMenu("Paint/Structure/Super Condition")]
	public class SuperCondition : MonoBehaviour, iFindComponents, iFindInChildren, iTestCondition, iHasLabel {
		
		public enum BranchActivationEnum {
			selected,
			all
		};
		
		public BranchActivationEnum branchAction = BranchActivationEnum.selected;
		
		public int activeBranch;
		
		protected List<aCondition> childConditions;
		
		protected List<Branch> branches;
		
		
		public void DefineLabel()
		{
			string conditionName = "";
			
			FindComponents();
			
			foreach(aCondition c in childConditions)
			{
				conditionName += " ? ["+c.GetConditionLabel()+"]";
			}
			
			gameObject.name = "Condition"+conditionName;
		}
		
		void Awake() {
			FindComponents();
			FindInChildren();
		}
		
		public void FindComponents()
		{
			aCondition[] _conditions = GetComponents<aCondition>();
			
			childConditions = new List<aCondition>();
			
			foreach(aCondition c in _conditions)
			{
				childConditions.Add(c);
			}
		}
		
		public void FindInChildren()
		{
			Branch[] _branches = GetComponentsInChildren<Branch>();
			
			branches = new List<Branch>();
			
			foreach(Branch b in _branches)
			{
				branches.Add(b);
			}
		}
		
		public bool TestCondition()
		{
			// if one child condition is false, return false
			foreach(aCondition c in childConditions)
			{
				if (!c.TestCondition())
					return false;
			}
			
			// if all conditions are true, return true
			return true;
		}
		
		public void ActiveBranchEffects()
		{
			if(branchAction == BranchActivationEnum.selected)
				branches[activeBranch].ActiveEffects();
			else
			{
				foreach(Branch b in branches)
				{
					b.ActiveEffects();
				}
			}
		}
	}

}
