using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public float speed ;

	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float input; //to get inout form arrow keys 

	// Use this for initialization
	void Start () {
		// Make a reference with the Transform Component
		this._transform = gameObject.GetComponent<Transform> ();


	}

	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position;
		this.input = Input.GetAxis ("Vertical");
		Debug.Log (this._currentPosition);

		if (this.input > 0)
			this._currentPosition += new Vector2 (0,this.speed);
		if (this.input < 0) {
			this._currentPosition -= new Vector2 (0, this.speed);
		
		}
		this.checkPosiiton ();
		this._transform.position = this._currentPosition;




	}

	public void checkPosiiton() {
		if (this._currentPosition.y < -200)
			this._currentPosition.y = -200;
		if (this._currentPosition.y > 200)
			this._currentPosition.y = 200;
	}
}
