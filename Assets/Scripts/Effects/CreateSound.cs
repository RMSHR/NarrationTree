using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSound : aEffect, iCanMakeSound {
	
	public AudioClip clip;

	protected override void OnEnable()
	{
		base.OnEnable();
		
		CreateNewSound(clip);
		
		PlayNextEffect();
	}
	
	public void CreateNewSound(AudioClip _clip)
	{
		GameObject _g = new GameObject();
		AudioSource _source = _g.AddComponent<AudioSource>();
		_source.clip = _clip;
		_source.Play();
	}
}
