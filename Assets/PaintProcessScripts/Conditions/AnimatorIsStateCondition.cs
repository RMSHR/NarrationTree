using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess{
	
	public class AnimatorIsStateCondition : aCondition {
		
		public Animator targetAnimator;
		public string stateName = "";
		
		public override bool TestCondition() {
			bool _matchName = targetAnimator.GetCurrentAnimatorStateInfo(0).IsName(stateName);
			
			return _matchName;
		}
	}

}