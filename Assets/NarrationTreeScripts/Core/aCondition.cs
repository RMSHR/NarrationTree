using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {

	[AddComponentMenu("Paint/Core/(abstract) Condition")]
	[RequireComponent(typeof(SuperCondition))]
	public abstract class aCondition : MonoBehaviour, iTestCondition {
		
		// TODO : How to use a float value and not only a bool value ?
		/*
		public enum ConditionOutEnum 
		{
			isBool,
			isConstFloat,
			isFromFloat
		}
		
		public ConditionOutEnum conditionOut = ConditionOutEnum.isBool;
		*/
		
		public virtual string GetConditionLabel()
		{
			return "";
		}
		
		public virtual bool TestCondition()
		{
			return true;
		}
	}
}
