using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {
	public string PlayerName;

	private static int health = 10;
	private static Attack attack1 = new Attack("Hit", 2, 5);
	private static Attack attack2 = new Attack("Stab", 5, 3);
	private static Attack attack3 = new Attack("Call for Help", 0, 0);
	private static Attack attack4 = new Attack ("Rest", 0, 0);
	
	public BasePlayer (string Name){
		this.PlayerName = Name;
	}

	public static int getHealth(){
		return health;
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
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
