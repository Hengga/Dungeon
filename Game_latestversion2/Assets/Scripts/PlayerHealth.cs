using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public float Health = 100f;
	private SpriteRenderer healthbar;
	private Vector3 healthscale;

	// Use this for initialization
	void Start () {
		healthbar = GameObject.Find ("Healtbar").GetComponent<SpriteRenderer>();
		healthscale = healthbar.transform.localScale;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Health <= 0) {
			Application.LoadLevel ("2_game");
		}

		if (Health > 100) {
			Health = 100;
			}

		HealthUpdate();
	}

		void HealthUpdate (){
		healthbar.transform.localScale = new Vector3 (healthscale.x * Health * 0.01f, 1, 1);
	}
		
	void OnCollisionStay2D (Collision2D Playerhit){

		if (Playerhit.gameObject.tag == "enemy") {
			Health -= 5;

			float verticalpush = Playerhit.gameObject.transform.position.y - transform.position.y;
			float horizontalpush = Playerhit.gameObject.transform.position.x - transform.position.x;

			GetComponent<Rigidbody2D>().AddForce(new Vector2(-horizontalpush, -verticalpush) * 2000);
			}

		}


	void OnTriggerEnter2D (Collider2D collider) {
		
		print ("triggerEnter");
		GameObject collidedWith = collider.gameObject;
		if (collidedWith.CompareTag ("Potion")) {
			Health += 100f;
		}
	}
}


