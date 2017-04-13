using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreSubstract : aStoreChangeValue {

	public override void PlayEffect()
	{
		base.PlayEffect();
		
		store.storedValue -= value;
	}
}
