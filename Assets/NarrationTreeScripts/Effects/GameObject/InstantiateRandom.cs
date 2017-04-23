using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	public class InstantiateRandom : aEffect {

		[Header("Prefab")]
		public List<GameObject> prefabs;
		
		[Header("Position")]
		public Vector3 newPositionMin;
		public Vector3 newPositionMax;
		
		[Header("Rotation")]
		public Vector3 newRotationMin;
		public Vector3 newRotationMax;
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			Vector3 pos = Vector3.zero;
			pos.x = Random.Range(newPositionMin.x, newPositionMax.x);
			pos.y = Random.Range(newPositionMin.y, newPositionMax.y);
			pos.z = Random.Range(newPositionMin.z, newPositionMax.z);
			
			Vector3 rotEuler = Vector3.zero;
			rotEuler.x = Random.Range(newRotationMin.x, newRotationMax.x);
			rotEuler.y = Random.Range(newRotationMin.y, newRotationMax.y);
			rotEuler.z = Random.Range(newRotationMin.z, newRotationMax.z);
			
			Quaternion rot = Quaternion.Euler(rotEuler);
			
			GameObject prefab = prefabs[Random.Range(0, prefabs.Count)];
			
			Instantiate(prefab, pos, rot);
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect Random Instantiate Prefabs";
		}
	}

}