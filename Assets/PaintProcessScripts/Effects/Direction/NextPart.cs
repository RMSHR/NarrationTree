using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
	
	[AddComponentMenu("Paint/Effects/Direction/Next Part")]
	public class NextPart : aEffect {
		
		protected DirectionMain direction;
		
		protected override void Awake(){
			base.Awake();
			
			direction = GameObject.FindObjectOfType<DirectionMain>();
		}
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			direction.NextPart();
		}
	}

}