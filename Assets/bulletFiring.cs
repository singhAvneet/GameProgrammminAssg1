using UnityEngine;
using System.Collections;

public class bulletFiring : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public float minVerticalSpeed = 5f;
	public float maxVerticalSpeed = 10f;
	public float minHorizontalSpeed = -2f;
	public float maxHorizontalSpeed = 2f;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _verticalSpeed;
	private float _horizontalDrift;
	//private bulletFiring enemy;
	public GameObject enemy;


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
		this._currentPosition -= new Vector2(this._horizontalDrift, this._verticalSpeed);
		this._transform.position = this._currentPosition;

		if (this._currentPosition.y <= -200) {
			this.Reset ();
		}
	}

	public void Reset() {

		this._verticalSpeed=3f;
		this._horizontalDrift = 2f;
		this._transform.position = this.enemy.transform.position;
	}
}
