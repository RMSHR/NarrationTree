using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	[AddComponentMenu("Paint/Effect/Sprite/Change Sprite")]
	public class ChangeSprite : aEffect {
		
		public SpriteRenderer rendererTarget;
		public Sprite newSprite;
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			rendererTarget.sprite = newSprite;
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect Change "+rendererTarget.gameObject.name+" Sprite to "+newSprite.name;
		}
	}

}