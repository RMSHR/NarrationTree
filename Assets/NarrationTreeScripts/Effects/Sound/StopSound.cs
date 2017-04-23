using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	public class StopSound : aActOnSound {

		public override void PlayEffect()
		{
			base.PlayEffect();
			
			audioTarget.Stop();
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect Stop Sound of "+audioTarget.name;
		}
	}

}