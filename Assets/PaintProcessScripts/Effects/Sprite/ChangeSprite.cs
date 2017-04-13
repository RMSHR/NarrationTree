using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
	
	[AddComponentMenu("Paint/Effect/Sprite/Change Sprite")]
	public class ChangeSprite : aEffect {
		
		public SpriteRenderer rendererTarget;
		public Sprite newSprite;
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			
		}
		
	}

}