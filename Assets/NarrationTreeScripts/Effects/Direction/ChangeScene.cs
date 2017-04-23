using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NarrationTree {
	
	public class ChangeScene : aEffect {
		
		public int newScene;
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			SceneManager.LoadScene(newScene);
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect Change Scene to"+newScene;
		}
	}

}