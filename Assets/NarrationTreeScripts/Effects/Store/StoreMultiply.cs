using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
		
	public class StoreMultiply : aStoreChangeValue {

		public override void PlayEffect()
		{
			base.PlayEffect();
			
			store.storedValue *= value;
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect Store * "+value;
		}
	}

}