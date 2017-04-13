using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
	
	[AddComponentMenu("Paint/Effects/Direction/Change Part")]
	public class ChangePart : aEffect {

		public int newPart;
		
		protected DirectionMain direction;
		
		protected override void Awake(){
			base.Awake();
			
			direction = GameObject.FindObjectOfType<DirectionMain>();
		}
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			direction.ChangePart(newPart);
		}
	}

}