using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	[AddComponentMenu("Paint/Conditions/Store Inferior")]
	public class StoreAskInferiorOrEqual : aStoreCountCondition {
		
		public override bool TestCondition()
		{
			if(store.storedValue <= valueToCompare)
				return true;
			else
				return false;
		}
		
		public override string GetConditionLabel()
		{
			
			return "Store "+storeName+" <= "+valueToCompare;
		}
	}

}