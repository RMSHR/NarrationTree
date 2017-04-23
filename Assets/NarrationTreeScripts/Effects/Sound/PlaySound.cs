using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	public class PlaySound : aActOnSound {
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			audioTarget.Play();
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect Play Sound "+audioTarget.name;
		}
	}

}