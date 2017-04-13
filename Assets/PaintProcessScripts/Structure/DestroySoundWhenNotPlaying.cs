using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PaintProcess {
	
	[AddComponentMenu("Paint/Structure/Destroy sound when not playing")]
	public class DestroySoundWhenNotPlaying : MonoBehaviour {

		AudioSource _source;
		
		void Awake() {
			_source = GetComponent<AudioSource>();
		}
		
		void Update () {
			if(!_source.isPlaying)
				Destroy(gameObject);
		}
	}

}