using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
	
	public class ChangePitch : aActOnSound {

		public float newPitch = 1f;

		public override void PlayEffect()
		{
			base.PlayEffect();
			
			_audioTarget.pitch = newPitch;
		}
	}

}
