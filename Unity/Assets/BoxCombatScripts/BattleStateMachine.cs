using UnityEngine;
using System.Collections;

public class BattleStateMachine : MonoBehaviour {
	public int playerhealth = BasePlayer.getHealth();
	public int enemyhealth = EnemyPlayer.getHealth();
	public string winning = "";
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
		currentState = BattleStates.START;
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
		GUI.Label (new Rect (20, 20, 100, 20), "Health: " + playerhealth);
		GUI.Label (new Rect (20, 40, 200, 20), "Enemy Health: " + enemyhealth);
		GUI.Label (new Rect (20, 60, 100, 20), winning);

		if (GUILayout.Button ("Attack")) {
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

		}
		if (currentState == BattleStates.ENEMYMOVE) {
			playerhealth -= EnemyPlayer.getAttack1();
			currentState = BattleStates.PLAYERMOVE;
		}


	}
}
