using UnityEngine;
using System.Collections;

public class EscapeButton : MonoBehaviour {

	public GUISkin gSkin;

	void OnGUI(){
		if (GUI.Button (new Rect(0,0,100,100), "Escape")){
			if(Application.CanStreamedLevelBeLoaded("test1")){
				Application.LoadLevel ("test1");
			}
		}
	}
}