using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	public class TreeLabel : MonoBehaviour {

		private string label = "";
		
		public void SetLabel(string _newLabel)
		{
			label = _newLabel;
		}
		
		public string GetLabel()
		{
			return label;
		}
	}

}