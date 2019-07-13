using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author : Chandra Delon
public class EffectDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//For Destroying Particle Effect of healing fountain
		Destroy(gameObject,2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
