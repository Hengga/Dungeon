using UnityEngine;
using System.Collections;

public class BossHealth : MonoBehaviour {
	public float Health = 1000f;
	private SpriteRenderer healthbar;
	private Vector3 healthscale;
	
	
	
	
	// Use this for initialization
	void Start () {
		healthbar = GameObject.Find ("BossHealtbar").GetComponent<SpriteRenderer>();
		healthscale = healthbar.transform.localScale;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//What happens when health 0
		
		if (Health <= 0) {
			Destroy(gameObject);
		}
		
		if (Health > 1000) {
			Health = 1000;
		}
		
		HealthUpdate();
		
		
	}
	
	void HealthUpdate (){
		healthbar.transform.localScale = new Vector3 (healthscale.x * Health * 0.001f, 1, 1);
	}
	
	void OnTriggerEnter2D (Collider2D Hit){
		if (Hit.gameObject.tag == "Miekka"){
			Health -= 20;
		}
	}
}


