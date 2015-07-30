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
		if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D>().AddForce (Vector2.right * speed);
			GetComponent<Animator>().SetBool("Walking", true);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Vector3 theScale = transform.localScale;
			theScale.x = 0.7f;
			transform.localScale = theScale;
		}

		if (Input.GetKeyUp (KeyCode.RightArrow)) {
			GetComponent<Animator>().SetBool("Walking", false);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().AddForce (-Vector2.right * speed);
			GetComponent<Animator>().SetBool("Walking", true);
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {	
			Vector3 theScale = transform.localScale;
			theScale.x = -0.7f;
			transform.localScale = theScale;
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {
			GetComponent<Animator> ().SetBool ("Walking", false);
		}
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D>().AddForce (Vector2.up * speed);
			GetComponent<Animator>().SetBool("Walking", true);

		}

			if (Input.GetKeyUp (KeyCode.UpArrow)) {
				GetComponent<Animator>().SetBool("Walking", false);
			}
			
		if (Input.GetKey (KeyCode.DownArrow)) {
		GetComponent<Rigidbody2D>().AddForce (-Vector2.up * speed);
			GetComponent<Animator>().SetBool("Walking", true);
		}

				if (Input.GetKeyUp (KeyCode.DownArrow)) {
			GetComponent<Animator> ().SetBool ("Walking", false);
		}



		if (Input.GetKey (KeyCode.X)) {
			anim.SetTrigger("Attack");
		}
	}
}


