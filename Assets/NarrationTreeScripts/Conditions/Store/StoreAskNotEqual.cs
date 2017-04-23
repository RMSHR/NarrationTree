using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	[AddComponentMenu("Paint/Conditions/Store Not Equal")]
	public class StoreAskNotEqual : aStoreCountCondition {

		public override bool TestCondition()
		{
			if(store.storedValue != valueToCompare)
				return true;
			else
				return false;
		}
		
		public override string GetConditionLabel()
		{
			
			return "Store "+storeName+" != "+valueToCompare;
		}
	}

}