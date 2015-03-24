using UnityEngine;
using System.Collections;

public class BattleStateMachine : MonoBehaviour {
	public int playerhealth = BasePlayer.getHealth();
	public int enemyhealth = EnemyPlayer.getHealth();
	public string winning = "";
	//MAKE THESE PASSED IN FROM PREVIOUS SCENE
	//public string Attack1 = "Hit";
	//public string Attack2 = "Stab";
	//public string Attack3 = "Call for Help";
	//public string Attack4 = "Rest";
	public Attack attack1 = new Attack("Hit", 2, 5);
	public Attack attack2 = new Attack("Stab", 5, 3);
	public Attack attack3 = new Attack("Call for Help", 0, 0);
	public Attack attack4 = new Attack ("Rest", 0, 0);

	public enum BattleStates{
		START,
		PLAYERMOVE,
		TRANSITION,
		ENEMYMOVE,
		LOSE,
		WIN
	}

	private BattleStates currentState;


	// Use this for initialization
	void Start () {
		currentState = BattleStates.PLAYERMOVE;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (currentState);
		switch (currentState) {
		case(BattleStates.START):
			break;
		case(BattleStates.PLAYERMOVE):
			break;
		case(BattleStates.TRANSITION):
			break;
		case(BattleStates.ENEMYMOVE):
			break;
		case(BattleStates.LOSE):
			break;
		case(BattleStates.WIN):
			GUI.Label (new Rect(20, 80, 200, 20), "YOU WON!");
			break;
		}
	}

	void OnGUI() {
		//need to work on not fixed postion for the Rectangle
		GUI.Label (new Rect (20, 20, 100, 20), "Health: " + playerhealth);
		GUI.Label (new Rect (20, 40, 200, 20), "Enemy Health: " + enemyhealth);
		GUI.Label (new Rect (20, 60, 100, 20), winning);
		GUI.Label (new Rect (275, 360, 100, 20), "Attacks");

		if (GUI.Button (new Rect (175, 400, 100, 20), attack1.Name)) {
			if (currentState == BattleStates.PLAYERMOVE){
				enemyhealth -= attack1.Damage;
				if(enemyhealth > 0){
					currentState = BattleStates.ENEMYMOVE;
				} else {
					enemyhealth = 0;
					winning = "You Win!";
					currentState = BattleStates.WIN;
				}
			}
		}



		if (GUI.Button (new Rect (325, 400, 100, 20), attack2.Name)) {
			if (currentState == BattleStates.PLAYERMOVE){
				enemyhealth -= attack2.Damage;
				currentState = BattleStates.ENEMYMOVE;
				if(enemyhealth > 0){
					currentState = BattleStates.ENEMYMOVE;
				} else {
					enemyhealth = 0;
					winning = "You Win!";
					currentState = BattleStates.WIN;
				}
			}
		}



		if (GUI.Button (new Rect (175, 430, 100, 20), attack3.Name)){
			if (currentState == BattleStates.PLAYERMOVE){
				enemyhealth -= attack3.Damage;
				currentState = BattleStates.ENEMYMOVE;
				if(enemyhealth > 0){
					currentState = BattleStates.ENEMYMOVE;
				} else {
					enemyhealth = 0;
					winning = "You Win!";
					currentState = BattleStates.WIN;
				}
			}
		}



		if (GUI.Button (new Rect (325, 430, 100, 20), attack4.Name)) {
			if (currentState == BattleStates.PLAYERMOVE){
				enemyhealth -= attack4.Damage;
				currentState = BattleStates.ENEMYMOVE;
				if(enemyhealth > 0){
					currentState = BattleStates.ENEMYMOVE;
				} else {
					enemyhealth = 0;
					winning = "You Win!";
					currentState = BattleStates.WIN;
				}
			}
		}

		if (currentState == BattleStates.ENEMYMOVE) {
			playerhealth -= EnemyPlayer.getAttack1 ();
			if(playerhealth > 0){
				currentState = BattleStates.PLAYERMOVE;
			} else {
				playerhealth = 0;
				winning = "You Lose!";
				currentState = BattleStates.LOSE;
			}
			
			
		}

		/*if (GUILayout.Button ("Attack")) {
			if (currentState == BattleStates.START) {
				//Stays in PLAYERMOVE to pick a move
				currentState = BattleStates.PLAYERMOVE;
			} else if (currentState == BattleStates.PLAYERMOVE) {
				enemyhealth = enemyhealth - BasePlayer.getAttack1();

				if (enemyhealth <= 0) {
					winning = "You win";
					currentState = BattleStates.WIN;
				} else {
					currentState = BattleStates.ENEMYMOVE;
				}
			} else if (currentState == BattleStates.ENEMYMOVE) {
				playerhealth = playerhealth - EnemyPlayer.getAttack1();

				if (playerhealth <= 0) {
					winning = "You Lose!";
					currentState = BattleStates.LOSE;

				} else {
					currentState = BattleStates.PLAYERMOVE;
				}
			} else if (currentState == BattleStates.WIN) {
				//Add code for ending scene
			} else if(currentState == BattleStates.LOSE) {
				//Add code for ending scene
			}

		}*/



	}
}

public class Attack {
	public string Name;
	public int Damage;
	public int Speed;

	public Attack(string name1, int damage1, int speed1){
		Name = name1;
		Damage = damage1;
		Speed = speed1;

	}

}
