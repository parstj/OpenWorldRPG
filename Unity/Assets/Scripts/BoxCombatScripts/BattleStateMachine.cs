using UnityEngine;
using System.Collections;

public class BattleStateMachine : MonoBehaviour
{

	private int playerhealth = BasePlayer.getHealth();
	private int enemyhealth;
	private int energy;
	public string winning = "";
	public string energyStatus = ""; //message will appear that says you're out of energy and cannot attack


	Attack attack1 = BasePlayer.getAttack1 ();
	Attack attack2 = BasePlayer.getAttack2 ();
	Attack attack3 = BasePlayer.getAttack3 ();
	Attack attack4 = BasePlayer.getAttack4 ();

 

	public enum BattleStates
	{
		START,
		PLAYERMOVE,
		NotEnoughEnergy,
		ENEMYMOVE,
		LOSE,
		WIN
	}

	private BattleStates currentState;


	// Use this for initialization
	void Start ()
	{
		currentState = BattleStates.PLAYERMOVE;

		playerhealth = BasePlayer.getHealth ();
		enemyhealth = EnemyPlayer.getHealth ();
		energy = BasePlayer.getEnergy ();
	}

	// Update is called once per frame
	void Update ()
	{
		//Debug.Log (currentState);
		switch (currentState) {
		case(BattleStates.START):
			break;
		case(BattleStates.PLAYERMOVE):
			break;
		case(BattleStates.ENEMYMOVE):
			break;
		case(BattleStates.NotEnoughEnergy):
			break;
		case(BattleStates.LOSE):
			goBackToOpenWorld();
			break;
		case(BattleStates.WIN):
			GUI.Label (new Rect (20, 80, 200, 20), "YOU WON!");
			goBackToOpenWorld();
			break;
		}
	}

	void OnGUI ()
	{

		//need to work on not fixed postion for the Rectangle
		GUI.Label (new Rect (20, 20, 100, 20), "Health: " + playerhealth);
		GUI.Label (new Rect (20, 40, 200, 20), "Enemy Health: " + enemyhealth);
		GUI.Label (new Rect (20, 60, 200, 20), "Energy: " + energy);
		GUI.Label (new Rect (20, 80, 100, 20), winning);
		GUI.Label (new Rect (20, 100, 100, 20), energyStatus);
		GUI.Label (new Rect (275, 360, 100, 20), "Attacks");
		//if (energy > 0) {

		if (energy >= attack1.EnergyCost) {
			if (GUI.Button (new Rect (175, 400, 100, 20), attack1.Name)) {
				if (currentState == BattleStates.PLAYERMOVE) {
					enemyhealth -= attack1.Damage;
					energy -= attack1.EnergyCost; 
					if (enemyhealth > 0) {
						currentState = BattleStates.ENEMYMOVE;
					} else {
						enemyhealth = 0;
						winning = "You Win!";
						currentState = BattleStates.WIN;
					}
				}

			} 
		} else if (GUI.Button (new Rect (325, 430, 100, 20), attack4.Name)) {
			if (currentState == BattleStates.PLAYERMOVE) {
				enemyhealth -= attack4.Damage;
				energy += attack4.EnergyCost; //gives player +2 energy 
				currentState = BattleStates.ENEMYMOVE;
				if (enemyhealth > 0) {
					currentState = BattleStates.ENEMYMOVE;
				} else {
					enemyhealth = 0;
					winning = "You Win!";
					currentState = BattleStates.WIN;
				}
			}
		}




		if /*(BasePlayer.canAttack (attack2)==true)*/(energy >= attack2.EnergyCost) {
			if (GUI.Button (new Rect (325, 400, 100, 20), attack2.Name)) {
				if (currentState == BattleStates.PLAYERMOVE) {
					enemyhealth -= attack2.Damage;
					energy -= attack2.EnergyCost; 
					currentState = BattleStates.ENEMYMOVE;
					if (enemyhealth > 0) {
						currentState = BattleStates.ENEMYMOVE;
					} else {
						enemyhealth = 0;
						winning = "You Win!";
						currentState = BattleStates.WIN;
					}
				}
			} 
		} else if (GUI.Button (new Rect (325, 430, 100, 20), attack4.Name)) {
			if (currentState == BattleStates.PLAYERMOVE) {
				enemyhealth -= attack4.Damage;
				energy += attack4.EnergyCost; //gives player +2 energy 
				currentState = BattleStates.ENEMYMOVE;
				if (enemyhealth > 0) {
					currentState = BattleStates.ENEMYMOVE;
				} else {
					enemyhealth = 0;
					winning = "You Win!";
					currentState = BattleStates.WIN;
				}
			}
		} 



		if /*(BasePlayer.canAttack (attack3)==true)*/(energy >= attack3.EnergyCost) {
			if (GUI.Button (new Rect (175, 430, 100, 20), attack3.Name)){
				if (currentState == BattleStates.PLAYERMOVE) {
					enemyhealth -= attack3.Damage;
					energy -= attack3.EnergyCost;
					currentState = BattleStates.ENEMYMOVE;
					if (enemyhealth > 0) {
						currentState = BattleStates.ENEMYMOVE;
					} else {
						enemyhealth = 0;
						winning = "You Win!";
						currentState = BattleStates.WIN;
					}
				}
			} 
		} else if (GUI.Button (new Rect (325, 430, 100, 20), attack4.Name)) {
			if (currentState == BattleStates.PLAYERMOVE) {
				enemyhealth -= attack4.Damage;
				energy += attack4.EnergyCost; //gives player +2 energy 
				currentState = BattleStates.ENEMYMOVE;
				if (enemyhealth > 0) {
					currentState = BattleStates.ENEMYMOVE;
				} else {
					enemyhealth = 0;
					winning = "You Win!";
					currentState = BattleStates.WIN;
				}
			}
		}





		if (GUI.Button (new Rect (325, 430, 100, 20), attack4.Name)) {
			if (currentState == BattleStates.PLAYERMOVE) {
				enemyhealth -= attack4.Damage;
				energy += attack4.EnergyCost; //gives player +2 energy 
				currentState = BattleStates.ENEMYMOVE;
				if (enemyhealth > 0) {
					currentState = BattleStates.ENEMYMOVE;
				} else {
					enemyhealth = 0;
					winning = "You Win!";
					currentState = BattleStates.WIN;
				}
			}
		}

		if (currentState == BattleStates.ENEMYMOVE) {
			playerhealth -= EnemyPlayer.getEnemyAttack ().Damage;
			if (playerhealth > 0) {
				currentState = BattleStates.PLAYERMOVE;
			} else {
				playerhealth = 0;
				winning = "You Lose!";
				currentState = BattleStates.LOSE;
			}
			
			
		}
			


	}

	//this function is added to make a playable game
	//to be replaced
	//by Yu Zhan
	void TestFunc (){
		Debug.Log("Test");
	}

	private void goBackToOpenWorld (){
		//yield return new WaitForSeconds(5);
		Invoke("TestFunc", 5f);
		if(winning == "You Win!"){
			Debug.Log("win here");
			if (Application.CanStreamedLevelBeLoaded ("test1")) {
				Application.LoadLevel ("test1");
			}
		}
		else if(winning == "You Lose!"){
			Debug.Log("lose here");
			if (Application.CanStreamedLevelBeLoaded ("Opening Scene")) {
				Application.LoadLevel ("Opening Scene");
			}
		}
	}



}



public class Attack
{
	public string Name;
	public int Damage;
	public int Speed;
	public int EnergyCost;

	public Attack (string name1, int damage1, int speed1, int cost)
	{
		Name = name1;
		Damage = damage1;
		Speed = speed1;
		EnergyCost = cost;
	}

}
/*
public class Enemy{
	public string Name;
	public int Level;
	public enum type {
		FAST,
		SLOW,
		LAZY
	} 
	public type TypeOfPlayer;
	public enum difficulty {
		EASY,
		MEDIUM,
		HARD
	} 
	public difficulty DifficultyOfPlayer;

	public Enemy (string name, int level, type type1, difficulty difficulty1){
		Name = name;
		Level = level;
		TypeOfPlayer = type1;
		DifficultyOfPlayer = difficulty1;
	}
	

	public Attack attack1 = new Attack("Hit", 2, 5, 2);
	public Attack attack2 = new Attack("Stab", 5, 3, 3);
	public Attack attack3 = new Attack("Scratch", 1, 0, 1);
	public Attack attack4 = new Attack ("Rest", 0, 0, 0);


}*/
