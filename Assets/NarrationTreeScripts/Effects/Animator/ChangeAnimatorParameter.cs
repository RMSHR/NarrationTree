using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	[AddComponentMenu("Paint/Effects/Animator/Change Parameter")]
	public class ChangeAnimatorParameter : aEffect {

		public enum ParameterTypeEnum {Float, Int, Bool, Trigger};
		
		public Animator animatorTarget;
		public ParameterTypeEnum parameterType = ParameterTypeEnum.Float;
		public string parameterName = "";
		public float floatValue;
		public int intValue;
		public bool boolValue;
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			switch(parameterType){
				case ParameterTypeEnum.Float:
					animatorTarget.SetFloat(parameterName, floatValue);
					break;
					
				case ParameterTypeEnum.Int:
					animatorTarget.SetInteger(parameterName, intValue);
					break;
					
				case ParameterTypeEnum.Bool:
					animatorTarget.SetBool(parameterName, boolValue);
					break;
					
				case ParameterTypeEnum.Trigger:
					animatorTarget.SetTrigger(parameterName);
					break;
			}
		}
	}

}