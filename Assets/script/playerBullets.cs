using UnityEngine;
using System.Collections;

public class playerBullets : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;


	//public bulletFiring enemy;
	public GameObject player;
	public float _horizontalDrift;


	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform>();
		// Reset the bullets` Sprite to the Top
		this.Reset ();
	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;

		this._currentPosition += new Vector2(this._horizontalDrift,0);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.x > this.player.transform.position.x +500||this._currentPosition.x < this.player.transform.position.x -500) {
			this.Reset ();
		}

	}

	public void Reset() {
		


		if (this.player == null) {
		
			Destroy (this.gameObject);
			return;
		
		}
		this._transform.position = this.player.transform.position;
		this._currentPosition = this._transform.position;

		if(player.tag=="dragion")
			this._currentPosition -= new Vector2(0,-8);
		else
			this._currentPosition -= new Vector2(0,14);

		this._transform.position = this._currentPosition;
	}



}
