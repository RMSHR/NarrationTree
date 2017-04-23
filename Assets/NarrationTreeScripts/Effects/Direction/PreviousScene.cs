using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NarrationTree {
	
	public class PreviousScene : aEffect {

		public override void PlayEffect()
		{
			base.PlayEffect();
			
			int thisLevel = SceneManager.GetActiveScene().buildIndex;
		   
			SceneManager.LoadScene(thisLevel - 1);
		}
		
		public override void DefineLabel()
		{
			base.DefineLabel();
			
			gameObject.name = "Effect Previous Scene";
		}
	}

}