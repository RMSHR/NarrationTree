using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	[DisallowMultipleComponent]
	[AddComponentMenu("Paint/Structure/Store")]
	public class Store : MonoBehaviour, iHasLabel {
		
		public string specificLabel = "";
		
		public int storedValue = 0;
		
		public void DefineLabel()
		{
			gameObject.name = "Store "+specificLabel;
		}
	}

}