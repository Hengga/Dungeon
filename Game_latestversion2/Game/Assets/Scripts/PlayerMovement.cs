using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
<<<<<<< HEAD
	Vector3 pos;                                // For movement
	float speed = 8.0f;       					// Speed of movement
	float distance = 2.0f;
	
	// Use this for initialization
	void Start () {
		pos = transform.position;          // Take the initial position
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetKey(KeyCode.A) && transform.position == pos) {        // Left
			pos += Vector3.left;
		}
		if(Input.GetKey(KeyCode.D) && transform.position == pos) {        // Right
			pos += Vector3.right;
		}
		if(Input.GetKey(KeyCode.W) && transform.position == pos) {        // Up
			pos += Vector3.up;
		}
		if(Input.GetKey(KeyCode.S) && transform.position == pos) {        // Down
			pos += Vector3.down;
		}
		transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
	}
}
=======

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
>>>>>>> 32d4b2ed8e1f1a931e04113a2c7a58e774d5b0ec
