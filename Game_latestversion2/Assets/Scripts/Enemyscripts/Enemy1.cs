using UnityEngine;
using System.Collections;

public class Enemy1 : MonoBehaviour {

	private Vector3 Player;
	private Vector2 Playerdirection;
	private float Xdif;
	private float Ydif;
	public float speed;
	private int Wall;
	private float distance;
	private bool stun;
	private float stuntime;


	void Start(){
		stuntime = 0;
		stun = false;
		Wall = 1 << 8;
	}


	

	void Update () {
		distance = Vector2.Distance (Player, transform.position);
		Player = GameObject.Find("Player").transform.position;

		if (stuntime > 0) {
			stuntime -= Time.deltaTime;
		} else {
			stun = false;
		}

		if (distance < 2 && !stun) {
			Xdif = Player.x - transform.position.x;
			Ydif = Player.y - transform.position.y;
			Playerdirection = new Vector2 (Xdif, Ydif);

			if (!Physics2D.Raycast (transform.position, Playerdirection, 0, Wall)) {
				GetComponent<Rigidbody2D> ().AddForce (Playerdirection.normalized * speed);
			}
		}
	}
	void OnCollisionEnter2D (Collision2D Playerhit){
		if (Playerhit.gameObject.tag == "pelaaja") {
			stun = true;
			stuntime = 1;
		}
	}
}
