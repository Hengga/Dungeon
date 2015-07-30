using UnityEngine;
using System.Collections;

public class BossGoal : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		print ("triggerEnter");
		GameObject collidedWith = collider.gameObject;
		if (collidedWith.CompareTag ("pelaaja")) {
			Application.LoadLevel("0_menu");
			
		}
	}
}

