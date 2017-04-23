using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
		
	public abstract class aStoreCountCondition : aCondition {

		public Store store;
		public int valueToCompare;
		
		protected string storeName = "";
		
		void Awake() {
			if(store == null)
			{
				store = GameObject.FindObjectOfType<Store>();
				if(store == null)
					Debug.LogError("Warning ! No StoreValue exist for "+gameObject.name);
			}
		}
		
		public override string GetConditionLabel()
		{			
			if(store == null)
				storeName = "[EMPTY]";
			else
				storeName = "["+store.name+"]";
			
			return "";
		}
	}
}