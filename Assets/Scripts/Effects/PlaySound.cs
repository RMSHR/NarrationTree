using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : aActOnSound {
	
	public override void PlayEffect()
	{
		base.PlayEffect();
		
		_audioTarget.Play();
	}
}
