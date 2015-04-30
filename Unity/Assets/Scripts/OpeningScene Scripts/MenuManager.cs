using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	void Start(){
		GameControl.control.PlayBgm1 ();
	}

	public void quitButtonClick(){
		Application.Quit();
	}

	public void newGameButtonClick(){
		GameControl.control.NewGame ();

		if(Application.CanStreamedLevelBeLoaded("test1")){
			Application.LoadLevel ("test1");
		}
	}

	public void loadGameButtonClick(){
		GameControl.control.Load ();

		if(Application.CanStreamedLevelBeLoaded("test1")){
			Application.LoadLevel ("test1");
		}
	}
}
