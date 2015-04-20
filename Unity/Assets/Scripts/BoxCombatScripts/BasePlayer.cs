using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {
	public string PlayerName;

	private static int health;
	private static int energy;
	private static Attack attack1 = new Attack("Hit", 2, 5, 2); 
	private static Attack attack2 = new Attack("Stab", 5, 3, 3);
	private static Attack attack3 = new Attack("Call for Help", 0, 0, 1);
	private static Attack attack4 = new Attack ("Rest", 0, 0, 2);
	
	public BasePlayer (string Name){
		this.PlayerName = Name;
	}

	public static int getHealth(){
		return health;
	}

	public static int getEnergy() {
		return energy;
	}


	public static Attack getAttack1() {
		return attack1;
	}
	public static Attack getAttack2() {
		return attack2;
	}
	public static Attack getAttack3() {
		return attack3;
	}
	public static Attack getAttack4() {
		return attack4; 
	}

	public void setAttack1 (Attack newAttack){
		attack1 = newAttack;
	}
	public void setAttack2 (Attack newAttack){
		attack2 = newAttack;
	}
	public void setAttack3 (Attack newAttack){
		attack3 = newAttack;
	}
	public void setAttack4 (Attack newAttack){
		attack4 = newAttack;
	}

	public static bool canAttack(Attack passedInAttack) {
		if (energy >= attack1.EnergyCost) {
			return true;
		} else {
			return false;
		}
		if (energy >= attack2.EnergyCost) {
			return true;
		} else {
			return false;
		}
		if (energy >= attack3.EnergyCost) {
			return true;
		} else {
			return false;
		}
	}



	// Use this for initialization
	void Start () {
		health = GameControl.control.curHealth;
		energy = GameControl.control.curEnergy;
//		Debug.Log (GameControl.control.health);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
