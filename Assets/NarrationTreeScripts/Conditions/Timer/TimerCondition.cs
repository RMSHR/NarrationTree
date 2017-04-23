using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
		
	[AddComponentMenu("Paint/Conditions/Counter")]
	public class TimerCondition : aCondition {

		public float delay = 1f;
		public bool repeatCounter = false;
		
		protected float counter;
		
		void Update () {
			counter += Time.deltaTime;
		}
		
		public override bool TestCondition() {
			if(counter >= delay)
			{
				if(repeatCounter)
					counter = 0f;
				
				return true;
			}
			else
				return false;
		}
		
		public override string GetConditionLabel()
		{
			
			return "Timer "+delay+" seconds";
		}
	}

}