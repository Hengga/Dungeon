﻿using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	static public bool goalMet = false;
	void OnTriggerEnter( Collider other ) {
		// When the trigger is hit by something
		// Check to see if it's a Projectile
		if (other.gameObject.tag == "Projectile") {
			print ("you won!");
			Goal.goalMet = true;
			// Also set the alpha of the color to higher opacity
			Color c = GetComponent<Renderer> ().material.color;
			c.a = 1;
			GetComponent<Renderer> ().material.color = c;
		}
	}
}