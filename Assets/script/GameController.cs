using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public Missile missileObj;
	//public GameObject coinsObj;
	private int missiles = 3;


	// Use this for initialization
	void Start () {
		//this._initialize ();
	}
	
	// Update is called once per frame
	void Update () {
		
			//this._initialize ();
	}

	private void _initialize(){
		//Destroy (missileObj.gameObject);
		for (int missileCount=0;missileCount<missiles;missileCount++) {
			Instantiate (missileObj.gameObject);		
		}
	
	}






}
