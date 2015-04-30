using UnityEngine;
using System.Collections;

public class DropDownMenu : MonoBehaviour {
	public GameObject menu;

	void DorpIt(){
		if (Application.loadedLevel != 1) {
			menu.SetActive(true);
		}
	}

	void Update(){
		if(Input.GetKeyDown(KeyCode.Escape)){
			DorpIt();
		}
	}

	public void ResumeIt(){
		menu.SetActive (false);
	}
	public void SaveIt(){
		GameControl.control.Save ();
		menu.SetActive (false);
	}
	public void LoadIt(){
		GameControl.control.Load ();
		menu.SetActive (false);
	}
	public void ReturnIt(){
		menu.SetActive (false);
		GameControl.control.Save ();
		
		if (Application.CanStreamedLevelBeLoaded ("Opening Scene")) {
			GameControl.control.PlayBgm2();
			Application.LoadLevel ("Opening Scene");
		}
	}
}