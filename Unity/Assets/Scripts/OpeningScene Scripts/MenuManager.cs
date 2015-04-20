using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
