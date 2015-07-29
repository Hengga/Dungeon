using UnityEngine;
using System.Collections;

public class PlayerMovementEz : MonoBehaviour {

	public float speed;
	Animator anim;

	void Start(){
		anim = GetComponent<Animator> ();
	}



	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody2D>().AddForce (Vector2.right * speed);

		}

		if (Input.GetKeyDown (KeyCode.D)) {
			Vector3 theScale = transform.localScale;
			theScale.x = 0.7f;
			transform.localScale = theScale;
		}

		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody2D> ().AddForce (-Vector2.right * speed);
		}

		if (Input.GetKeyDown (KeyCode.A)) {	
			Vector3 theScale = transform.localScale;
			theScale.x = -0.7f;
			transform.localScale = theScale;
		}

		
		if (Input.GetKey (KeyCode.W)) {
			GetComponent<Rigidbody2D>().AddForce (Vector2.up * speed);

		}
			
		if (Input.GetKey (KeyCode.S)) {
		GetComponent<Rigidbody2D>().AddForce (-Vector2.up * speed);
		}

		if (Input.GetKeyDown (KeyCode.F)) {
			anim.SetTrigger("Attack");
			}
	}
}
