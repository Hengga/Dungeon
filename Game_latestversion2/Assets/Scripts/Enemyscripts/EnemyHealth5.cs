using UnityEngine;
using System.Collections;

public class EnemyHealth5 : MonoBehaviour {
	public float Health = 100f;
	private SpriteRenderer healthbar;
	private Vector3 healthscale;
	
	
	
	
	// Use this for initialization
	void Start () {
		healthbar = GameObject.Find ("EnemyHealtbar5").GetComponent<SpriteRenderer>();
		healthscale = healthbar.transform.localScale;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//What happens when health 0
		
		if (Health <= 0) {
			
			Destroy(gameObject);
		}
		
		if (Health > 100) {
			Health = 100;
		}
		
		HealthUpdate();
		
		
	}
	
	void HealthUpdate (){
		healthbar.transform.localScale = new Vector3 (healthscale.x * Health * 0.01f, 1, 1);
	}
	
	void OnTriggerEnter2D (Collider2D Hit){
		if (Hit.gameObject.tag == "Miekka"){
			Health -= 20;
			float verticalpush = Hit.gameObject.transform.position.y - transform.position.y;
			float horizontalpush = Hit.gameObject.transform.position.x - transform.position.x;
			
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-horizontalpush, -verticalpush) * 2000);
		}
	}
}



