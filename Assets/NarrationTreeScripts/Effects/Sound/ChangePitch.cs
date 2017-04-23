using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	public class ChangePitch : aActOnSound {

		public float newPitch = 1f;

		public override void PlayEffect()
		{
			base.PlayEffect();
			
			audioTarget.pitch = newPitch;
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect Change Pitch of "+audioTarget.name+" to "+newPitch;
		}
	}

}
