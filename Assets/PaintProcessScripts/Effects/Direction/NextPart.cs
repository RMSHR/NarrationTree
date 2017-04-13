using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Paint/Effects/Direction/Next Part")]
public class NextPart : ChangePart {
	
	public override void PlayEffect()
	{
		base.PlayEffect();
		
		direction.NextPart();
	}
}
