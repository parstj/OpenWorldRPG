using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {
	public string PlayerName;

	public GameObject enemy1;
	public GameObject enemy2;
	private static int health;
	private static int energy;
	private static Attack attack1 = new Attack("Hit", 2, 5, 2); 
	private static Attack attack2 = new Attack("Stab", 5, 3, 3);
	private static Attack attack3 = new Attack("Call for Help", 0, 0, 1);
	private static Attack attack4 = new Attack ("Rest", 0, 0, 2);
	public int level; 
	private static int experience;
	//private int damageMultiplier;
	
	public BasePlayer (string Name){
		this.PlayerName = Name;
	}

	public static int getHealth(){
		return health;
	}

	public static int getExperience(){
		return experience;
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

	/*public static bool canAttack(Attack passedInAttack) {
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
	}*/


	void Awake(){
		if (GameControl.control.openWorldData.enemyType == 1) {
			enemy1.SetActive (true);
			enemy2.SetActive (false);
		} else if (GameControl.control.openWorldData.enemyType == 2) {
			enemy2.SetActive (true);
			enemy1.SetActive (false);
		} else {

		}

	}


	// Use this for initialization
	void Start () {
		health = GameControl.control.playerData.curHealth;
		energy = GameControl.control.playerData.curEnergy;
		experience = GameControl.control.playerData.curExperience;
		level = GameControl.control.playerData.level;
		//damageMultiplier = GameControl.control.playerData.curDamageMultiplier;
//		Debug.Log (GameControl.control.health);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
