using UnityEngine;
using System.Collections;

public class DropDownMenu : MonoBehaviour {
	public GameObject menu;

	void DorpIt(){
		if (Application.loadedLevel != 0) {
			if(!menu.activeSelf){
				menu.SetActive(true);
			} else{
				menu.SetActive(false);
			}
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

		if(Application.CanStreamedLevelBeLoaded("test1")){
			Application.LoadLevel ("test1");
		}
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