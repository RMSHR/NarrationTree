using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSound : aActOnSound {

	public override void PlayEffect()
	{
		base.PlayEffect();
		
		_audioTarget.Stop();
	}
}
