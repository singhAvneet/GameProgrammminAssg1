using UnityEngine;
using System.Collections;

public class GroundEnemyDestroy : MonoBehaviour {
	public GameObject blast;
	private int lives = 5;
	// Use this for initialization
	void Start () {
	//	this._transform = gameObject.GetComponent<Transform> ();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "playerBullet"&& this.lives<0){
			Instantiate (blast, other.transform.position, other.transform.rotation);
			//Destroy (other.gameObject);
			Destroy (this.gameObject);

		}
		this.lives -= 1;
	}
}
