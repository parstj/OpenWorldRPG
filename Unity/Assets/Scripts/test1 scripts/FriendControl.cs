using UnityEngine;
using System.Collections;

public class FriendControl : MonoBehaviour {
	public GameObject camera1;
	public GameObject camera2;
	public GameObject exit;

	public void Accept(){
		GameControl.control.openWorldData.mission1.started = true;
		camera1.SetActive (true);
		camera2.SetActive (false);
	}

	public void Refuse(){
		camera1.SetActive (true);
		camera2.SetActive (false);
	}
}
