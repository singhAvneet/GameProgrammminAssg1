using UnityEngine;
using System.Collections;

public class DaigonalFiring : MonoBehaviour {
	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _horizontalDrift=-20f;
	private float _VertivalDrift=-17f;

	//public bulletFiring enemy;
	public GameObject helicop;
	public Transform hero;



	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform>();
		// Reset the bullets` Sprite to the Top
		this.Reset (_horizontalDrift);

	}

	// Update is called once per frame
	void Update () {
		
			this._currentPosition = this._transform.position;
			this._currentPosition += new Vector2 (this._horizontalDrift, this._VertivalDrift );
			this._transform.position = this._currentPosition;
		if (this._currentPosition.x < this.helicop.transform.position.x-1000) {
			this.Reset (_horizontalDrift);
		}


	}

	public void Reset(float speed) {

		this._horizontalDrift =speed ;

		if (this.helicop == null) {

			Destroy (this.gameObject);
			return;

		}
		this._transform.position = this.helicop.transform.position;
		this._currentPosition = this._transform.position;
		//this._currentPosition -= new Vector2(0,-22f);
		this._transform.position = this._currentPosition;

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "helicopter")
			return;
		else if (other.tag == "Player") {
			this.hero.position = new Vector2 (0f, 0f); 

		}
		
	}

}
