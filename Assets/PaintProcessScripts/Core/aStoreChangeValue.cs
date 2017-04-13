using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
	
	[AddComponentMenu("Paint/Core/(abstract) Store Change Value")]
	public class aStoreChangeValue : aEffect {

		public StoreValue store;
		public int value;
		
		protected override void Awake() {
			base.Awake();
			
			if(store == null)
			{
				store = GameObject.FindObjectOfType<StoreValue>();
				if(store == null)
					Debug.LogError("Warning ! No StoreValue exist for "+gameObject.name);
			}
		}
	}

}