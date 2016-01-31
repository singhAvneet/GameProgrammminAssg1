using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	public GameObject playerExplosion;
	private Transform _transform;
	public static bool  isPlayerCollided = false;
	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();


	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "playerBullet") {

			return;
		}
			Instantiate (playerExplosion, other.transform.position,other.transform.rotation);
			Destroy (other.gameObject);
			Destroy (this.gameObject);

		isPlayerCollided = true;



	}


}
