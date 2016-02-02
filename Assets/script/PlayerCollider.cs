using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {
	//public gameObjects
	public GameObject playerExplosion;
	public GameObject coinsObj;
	public Missile missileObj;
	public GameController gameController;
	public GameObject playerObj;
	//private variables
	private int score,count=1;
	private Transform _transform;
	private int missiles = 3;
	private bool isEmpty = false;
	private AudioSource[] audioSources;
	private AudioSource engine;


	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();	
		this._initialize ();

		//initialize the audio sources array
		this.audioSources = gameObject.GetComponents<AudioSource> ();
		this.engine = this.audioSources [0];

	}

	void Update(){

		//Debug.Log (score);
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "playerBullet")
			return;
		else if (other.tag == "coins") {
			this.engine.Play ();
			count++;
			score = score + 100;

			this.gameController.ScoreValue += 100;
			Destroy (other.gameObject);
			if (count % 3 == 0) {
				this._initialize ();
			}
			return;
		}
		if (this.gameController.LivesValue < 1) {
			Instantiate (playerExplosion, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		} else {
			//Destroy (this.gameObject);
			this.gameObject.transform.position=new Vector2(transform.position.x,0);
			//nstantiate (playerObj.gameObject, other.transform.position, other.transform.rotation);
				
			this.gameController.LivesValue -= 1;
		}
			

	}

	private void _initialize(){
		isEmpty = false;
		//Destroy (missileObj.gameObject);
		for (int missileCount=0;missileCount<missiles;missileCount++) {
			Instantiate (missileObj.gameObject);		
		}
}
}