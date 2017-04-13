﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PaintProcess {
	
	public class ChangeScene : aEffect {
		
		public int newScene;
		
		public override void PlayEffect()
		{
			base.PlayEffect();
			
			SceneManager.LoadScene(newScene);
		}
	}

}