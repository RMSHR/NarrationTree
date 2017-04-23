using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	public class Instantiate : aEffect {

		public GameObject prefab;
		
		public Vector3 newPosition;
		public Vector3 newRotation;
		
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			Quaternion rot = Quaternion.Euler(newRotation);
			
			Instantiate(prefab, newPosition, rot);
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect Instantiate "+prefab.name;
		}
	}

}