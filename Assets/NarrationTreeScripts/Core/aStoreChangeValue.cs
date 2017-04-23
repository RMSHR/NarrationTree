using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	[AddComponentMenu("Paint/Core/(abstract) Store Change Value")]
	public class aStoreChangeValue : aEffect {

		public Store store;
		public int value;
		
		protected override void Awake() {
			base.Awake();
			
			if(store == null)
			{
				store = GameObject.FindObjectOfType<Store>();
				if(store == null)
					Debug.LogError("Warning ! No Store exist for "+gameObject.name);
			}
		}
	}

}