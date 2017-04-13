using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
		
	public abstract class aStoreCountCondition : aCondition {

		public StoreValue store;
		public int valueToCompare;
		
		void Awake() {
			if(store == null)
			{
				store = GameObject.FindObjectOfType<StoreValue>();
				if(store == null)
					Debug.LogError("Warning ! No StoreValue exist for "+gameObject.name);
			}
		}
	}

}