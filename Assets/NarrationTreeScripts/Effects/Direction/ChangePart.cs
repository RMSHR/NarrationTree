using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	[AddComponentMenu("Paint/Effects/Direction/Change Part")]
	public class ChangePart : NextPart {

		public int newPart;
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			direction.ChangePart(newPart);
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect Change Part to "+newPart;
		}
	}

}