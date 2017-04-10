using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
