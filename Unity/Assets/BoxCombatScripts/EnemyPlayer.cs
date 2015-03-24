using UnityEngine;
using System.Collections;

public class EnemyPlayer : MonoBehaviour {

	public string EnemyName;
	private static int health = 10;
	
	public static int getHealth(){
			return health;
	}
	public static int attack1 = 3;
	
	public static int getAttack1() {
		return attack1;
	}
	
	public static int attack2 = 5;
	
	public static int getAttack2() {
		return attack2;
	}


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
