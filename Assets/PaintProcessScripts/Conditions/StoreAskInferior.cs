using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
	
	[AddComponentMenu("Paint/Conditions/Store Inferior")]
	public class StoreAskInferior : aStoreCountCondition {
		
		public override bool TestCondition()
		{
			if(store.storedValue < valueToCompare)
				return true;
			else
				return false;
		}
	}

}