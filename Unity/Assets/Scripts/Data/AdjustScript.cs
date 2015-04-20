using UnityEngine;
using System.Collections;

public class AdjustScript : MonoBehaviour {

	void OnGUI(){
		if (GUI.Button (new Rect (10, 100, 150, 30), "Health up")) {
			GameControl.control.health += 10;
		}
		if (GUI.Button (new Rect (10, 140, 150, 30), "Health down")) {
			GameControl.control.health -= 10;
		}
		if (GUI.Button (new Rect (10, 180, 150, 30), "Experience up")) {
			GameControl.control.experience += 10;
		}
		if (GUI.Button (new Rect (10, 220, 150, 30), "Experience down")) {
			GameControl.control.experience -= 10;
		}
	}
}
