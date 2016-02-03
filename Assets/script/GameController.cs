using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour{
	//private instance varialble
	private int _scoreValue;
	private int _livesValue;
	private int missiles = 3;

	private string str="Surpeet never looses" ;


	//public instance variable
	public Missile missileObj;
	public Text score;
	public Text lives;
	public Text winnerLoser;
	public GameObject player;
	public GameObject airEnemy;
	public GameObject groundEnemy;
	public GameObject missileEnemy;

	//public access methods
	public int ScoreValue{get { return _scoreValue;} set{ this._scoreValue = value;}}
	public int LivesValue{get {return _livesValue; } set {this._livesValue = value; }}


	// Use this for initialization
	void Start () {
		this._initialize ();

	}
	
	// Update is called once per frame
	void Update () {
		this.score.text = "Score: " + this._scoreValue;
		this.lives.text = "Lives: " + this._livesValue;
		//if (this.groundEnemy == null ) 
		//	if(this.airEnemy == null)
		if (this.groundEnemy == null) 
			if (this.airEnemy == null)
				if (this.missileEnemy == null)
					this.winnerLoser.text = "Surpreet You Win !";
			//this.method1 ();

		if (this.player == null) {

			this.winnerLoser.text =str;

		}
	}

	private void _initialize(){
		this.ScoreValue = 0;
		this.LivesValue = 3;

		//Destroy (missileObj.gameObject);
		/*for (int missileCount=0;missileCount<missiles;missileCount++) {
			Instantiate (missileObj.gameObject);	*/	
		
		}

	private void method1 (){
		if (this.airEnemy == null)
			this.method2();
			//this.winnerLoser.text = "You Win !";
			//

			
		
	}

	private void method2(){
		if (this.missileEnemy == null)
			this.winnerLoser.text = "You Win !";
		

}



}