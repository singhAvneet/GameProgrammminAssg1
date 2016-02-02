using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//private instance varialble
	private int _scoreValue;
	private int _livesValue;
	private int missiles = 3;

	//public instance variable
	public Missile missileObj;
	//public access methods

	public int ScoreValue{ get { return _scoreValue;} set{ this._scoreValue = value;}}
			public int LivesValue{get {return _livesValue; } set {this._livesValue = value;Debug.Log(this._livesValue); }}


	// Use this for initialization
	void Start () {
		this._initialize ();
	}
	
	// Update is called once per frame
	void Update () {

			//this._initialize ();
	}

	private void _initialize(){
		this.ScoreValue = 0;
		this.LivesValue = 3;
		//Destroy (missileObj.gameObject);
		/*for (int missileCount=0;missileCount<missiles;missileCount++) {
			Instantiate (missileObj.gameObject);	*/	
		}
	
	}







