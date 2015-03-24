using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {
	public string PlayerName;

	private static int health = 10;

	public static int getHealth(){
		return health;
	}
	/*
	public static int getHealth{
		get{
			return health;
		}

	}
	*/
	public static int attack1 = 5;

	public static int getAttack1() {
		return attack1;
	}

	public static int attack2 = 5;

	public static int getAttack2() {
		return attack2;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
