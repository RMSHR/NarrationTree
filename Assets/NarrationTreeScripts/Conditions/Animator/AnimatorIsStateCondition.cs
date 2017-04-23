using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	public class AnimatorIsStateCondition : aCondition {
		
		public Animator targetAnimator;
		public string stateName = "";
		
		public override bool TestCondition() {
			bool _matchName = targetAnimator.GetCurrentAnimatorStateInfo(0).IsName(stateName);
			
			return _matchName;
		}
		
		public override string GetConditionLabel()
		{
			string animatorName = "";
			
			if(targetAnimator == null)
				animatorName = "[EMPTY]";
			else
				animatorName = targetAnimator.name;
			
			return "Animator "+animatorName+" State == "+stateName;
		}
	}

}