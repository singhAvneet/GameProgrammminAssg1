using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {
	//public gameObjects
	public GameObject playerExplosion;
	public GameObject coinsObj;
	public Missile missileObj;
	//private variables
	private int score,count=1;
	private Transform _transform;
	private int missiles = 3;
	private bool isEmpty = false;
	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();	
		this._initialize ();
	}

	void Update(){
	
		Debug.Log (count);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "playerBullet")
			return;
		else if (other.tag == "coins") {
			count++;
			Destroy (other.gameObject);
			if (count % 3 == 0) {
				Destroy (other.gameObject);
				this._initialize ();
			}
			return;
		}
			Instantiate (playerExplosion, other.transform.position,other.transform.rotation);
			Destroy (other.gameObject);
			Destroy (this.gameObject);
	}

	private void _initialize(){
		isEmpty = false;
		//Destroy (missileObj.gameObject);
		for (int missileCount=0;missileCount<missiles;missileCount++) {
			Instantiate (missileObj.gameObject);		
		}
}
}