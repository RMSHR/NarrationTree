using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
		
	public class StoreMultiply : aStoreChangeValue {

		public override void PlayEffect()
		{
			base.PlayEffect();
			
			store.storedValue *= value;
		}
	}

}