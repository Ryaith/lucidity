﻿using UnityEngine;
using System.Collections;

public class GravityAttractor : MonoBehaviour {
	
	public float gravity = -9.8f;
	
	
	public void Attract(CharacterController body) {
		Vector3 gravityUp = (body.transform.position - transform.position).normalized;
		Vector3 localUp = body.transform.up;
		
		// Apply downwards gravity to body
		//body.attachedRigidbody.AddForce(gravityUp * gravity);
		// Allign bodies up axis with the centre of planet
		body.transform.rotation = Quaternion.FromToRotation(localUp,gravityUp) * body.transform.rotation;
	}  
}
