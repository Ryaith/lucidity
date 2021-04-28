using UnityEngine;
using System.Collections;

public class GravityBody : MonoBehaviour {
	
	GravityAttractor planet;
	CharacterController player;

	void Awake () {
		planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<GravityAttractor>();
		player = GetComponent<CharacterController>();


	}
	
	void FixedUpdate () {
		// Allow this body to be influenced by planet's gravity
		planet.Attract(player);
	}
}