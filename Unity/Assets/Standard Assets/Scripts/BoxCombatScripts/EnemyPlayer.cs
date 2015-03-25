using UnityEngine;
using System.Collections;

public class EnemyPlayer {

	public string EnemyName;
	//private static int health = 10;
	private int Health;

	private static Attack attack1 = new Attack("Hit", 2, 5);
	private static Attack attack2 = new Attack("Stab", 5, 3);
	private static Attack attack3 = new Attack("Scratch", 1, 0);
	private static Attack attack4 = new Attack ("Rest", 0, 0);

	public EnemyPlayer (string name, int health){
		this.EnemyName = name;
		this.Health = health;
	}

	
	public int getHealth(){
			return Health;
	}

	public static Attack getEnemyAttack(){

		int random = Mathf.FloorToInt (Random.Range (1, 5));
		Attack returnAttack;
		if (random == 1) {
			returnAttack = attack1;
		} else if (random == 2) {
			returnAttack = attack2;
		} else if (random == 3) {
			returnAttack = attack3;
		}else{
			returnAttack = attack4;
		}
		return returnAttack;
	}

	public static Attack getAttack1(){
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

	/*
	//public static int attack1 = 3;
	public static int getAttack1() {
		return attack1;
	}
	
	//public static int attack2 = 5;
	
	public static int getAttack2() {
		return attack2;
	}
	*/


}
