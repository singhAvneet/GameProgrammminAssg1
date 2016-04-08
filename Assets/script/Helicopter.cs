
using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {
	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _horizontalDrift;
	private float _verticalPosition;
	private int _enemyLives;


	public GameObject _hero;
	public GameObject blast;


	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform>();
		// Reset the bullets` Sprite to the Top
		this.Reset ();
		this._enemyLives = 3;

	}

	// Update is called once per frame
	void Update () {

		this._currentPosition = this._transform.position;
		this._currentPosition.y = this._verticalPosition;
		this._currentPosition -= new Vector2(this._horizontalDrift,5f);

		if (this._currentPosition.x < _hero.transform.position.x+100) {
			this._transform.position = new Vector2 (this._currentPosition.x+200,this._currentPosition.y);
			this._horizontalDrift = 0f;
		}
		else
			this._transform.position = this._currentPosition;
	}

	void OnTriggerEnter2D(Collider2D other){
		Instantiate (blast, other.transform.position, other.transform.rotation);
		if (other.tag == "bullet") {
			this.Reset ();
			this._enemyLives--;
		}
		if (this._enemyLives < 1) {
			//this._verticalPosition = Random.Range (-680f, 0f);
			//this._horizontalDrift = 0f;
			Destroy(this.gameObject);
		}
	}



	public void Reset() {
		
		this._verticalPosition = Random.Range (50f,100f);
		this._horizontalDrift = 10f;
		this._transform.position = new Vector2 (1096f,0f);

	}
}
