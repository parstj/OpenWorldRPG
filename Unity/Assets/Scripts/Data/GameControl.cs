using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public static GameControl control;

	public int level;
	public int curHealth;
	public int curEnergy;
	public int curExperience;
	public int curDamageMultiplier;
	
	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if(control != this){
			Destroy(gameObject);
		}
	}
	
//	void OnGUI(){
//		GUI.Label (new Rect(10, 10, 150, 30), "Health: " + health);
//		GUI.Label (new Rect(10, 40, 150, 30), "Experience: " + experience);
//	}
}
