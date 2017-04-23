using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NarrationTree {
	
	public class Paint : MonoBehaviour {

		protected MeshRenderer _meshRenderer;
		protected Animator _animator;
		
		void Awake() {
			_animator = GetComponent<Animator>();
			_meshRenderer = GetComponent<MeshRenderer>();
		}
	}

}