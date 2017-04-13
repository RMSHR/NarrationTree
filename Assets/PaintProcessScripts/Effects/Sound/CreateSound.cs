using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSound : aEffect, iCanMakeSound {
	
	public AudioClip clip;
	public float startPitch = 1f;

	public override void PlayEffect()
	{
		base.PlayEffect();
		
		CreateNewSound(clip);
	}
	
	public void CreateNewSound(AudioClip _clip)
	{
		// create new gameobject with AudioSource and the chosen clip
		
		GameObject _g = new GameObject();
		_g.name = "Sound ["+clip.name+"]";
		AudioSource _source = _g.AddComponent<AudioSource>();
		_g.AddComponent<DestroySoundWhenNotPlaying>();
		_source.clip = _clip;
		_source.pitch = startPitch;
		_source.Play();
	}
}
