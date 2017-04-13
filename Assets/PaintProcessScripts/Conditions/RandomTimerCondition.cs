﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
	
	public class RandomTimerCondition : TimerCondition {
		
		public float delayMin, delayMax;
		
		void Awake() {
			SetRandomCounter();
		}
		
		public override bool TestCondition() {
			if(counter >= delay)
			{
				if(repeatCounter)
					counter = 0f;
				
				SetRandomCounter();
				
				return true;
			}
			else
				return false;
		}
		
		void SetRandomCounter() {
			delay = Random.Range(delayMin, delayMax);
		}
	}

}