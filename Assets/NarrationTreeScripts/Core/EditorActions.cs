using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace NarrationTree {
	
	public class EditorActions : MonoBehaviour {

		
		[MenuItem("Narration Tree/Create base Narration Tree")]
		public static void CreateBase() 
		{
			Debug.Log("Creating base Narration Tree");
			
			// Singleton
			DirectionMain _main = GameObject.FindObjectOfType<DirectionMain>();
			
			if(_main != null)
			{
				Debug.LogError("Already one Direction Main");
				return;
			}
			
			// Create
			// DIRECTION MAIN
			GameObject directionMain = new GameObject();
			directionMain.AddComponent<DirectionMain>();
			directionMain.GetComponent<DirectionMain>().DefineLabel();
			
			// DIRECTION PART
			GameObject directionPart = new GameObject();
			directionPart.AddComponent<DirectionPart>();
			directionPart.transform.parent = directionMain.transform;
			directionPart.GetComponent<DirectionPart>().DefineLabel();
			
			// CONDITION
			GameObject condition = new GameObject();
			condition.transform.parent = directionPart.transform;
			condition.name = "Empty Condition";
			
			// BRANCH
			GameObject branch = new GameObject();
			branch.AddComponent<Branch>();
			branch.transform.parent = condition.transform;
			branch.GetComponent<Branch>().DefineLabel();
			
			// EFFECT
			GameObject effect = new GameObject();
			effect.transform.parent = branch.transform;
			effect.name = "Empty Effect";
		}
		
		[MenuItem("Narration Tree/Rename All")]
		public static void RenameAll() {
			List<iHasLabel> labels = InterfaceHelper.FindObjects<iHasLabel>() as List<iHasLabel>;
			
			foreach(iHasLabel node in labels)
			{
				node.DefineLabel();
			}
		}
		
		[MenuItem("Narration Tree/Rename From Selected")]
		public static void RenameFromSelected() {
			List<iHasLabel> labels = InterfaceHelper.GetInterfaceComponents<iHasLabel>(Selection.activeTransform) as List<iHasLabel>;
			
			foreach(iHasLabel node in labels)
			{
				node.DefineLabel();
			}
		}
		
		[MenuItem("Narration Tree/Rename This Only")]
		public static void RenameThisOnly() {
			Debug.Log("Rename only "+Selection.activeTransform.gameObject.name);
			
			List<iHasLabel> labels = InterfaceHelper.GetInterfaceComponents<iHasLabel>(Selection.activeTransform) as List<iHasLabel>;

			labels[0].DefineLabel(); // hack
		}
	}

}