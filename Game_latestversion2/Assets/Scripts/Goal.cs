using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		print ("triggerEnter");
		GameObject collidedWith = collider.gameObject;
		if (collidedWith.CompareTag ("pelaaja")) {
			Application.LoadLevel("3_game");

		}
	}

}
