using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {
	static public FollowCam S;
	public Vector2 minXY;
	public GameObject poi;
	public float camZ;
	public float easing = 0.05f;

	// Use this for initialization
	void Awake () {
		S = this;
		camZ = this.transform.position.z;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 destination;
		// If there is no poi, return to P[0, 0, 0]
		if (poi == null) {
			destination = Vector3.zero;
		} else {
			// get the position of the poi
			destination = poi.transform.position;
			// If poi is a projectile, check to see if it's at rest
			if (poi.tag == "Projectile") {
				// If it's sleeping (that is not moving)
				if (poi.GetComponent<Rigidbody> ().IsSleeping ()) {
					// return to default view in the next update
					poi = null;
					return;
				}
			}
		}
		destination.x = Mathf.Max (minXY.x, destination.x);
		destination.y = Mathf.Max (minXY.y, destination.y);
		destination = Vector3.Lerp (transform.position, destination, easing);
		destination.z = camZ;
		transform.position = destination;
		this.GetComponent<Camera>().orthographicSize = destination.y + 10;
	}
}
