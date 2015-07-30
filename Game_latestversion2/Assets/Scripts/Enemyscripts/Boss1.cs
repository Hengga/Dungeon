using UnityEngine;
using System.Collections;

public class Boss1 : MonoBehaviour {
	public float speed = 1f;
	public float downEdge = 1f;
	public float upEdge = 5f;
	

	void Update (){
		Vector3 savedBossPosition = transform.position;
		savedBossPosition.y +=speed *Time.deltaTime;
		transform.position = savedBossPosition;

		if (savedBossPosition.y < -0.25) {
			speed = Mathf.Abs (speed);
		}
		else if (savedBossPosition.y > 1.79) {
			speed = -Mathf.Abs (speed);
		}
	}
}