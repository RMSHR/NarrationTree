﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
	
	[AddComponentMenu("Paint/Conditions/Store Equal")]
	public class StoreAskEqual : aStoreCountCondition {
		
		public override bool TestCondition()
		{
			if(store.storedValue == valueToCompare)
				return true;
			else
				return false;
		}
	}

}