using UnityEngine;
using System.Collections;

public class FriendControl : MonoBehaviour {
	public GameObject camera1;
	public GameObject camera2;

	public GameObject returnPoint;
	public GameObject player;

	public void Accept(){
		GameControl.control.openWorldData.mission1.started = true;
		player.transform.position = returnPoint.transform.position;
		camera1.SetActive (true);
		camera2.SetActive (false);
	}

	public void Refuse(){
		player.transform.position = returnPoint.transform.position;
		camera1.SetActive (true);
		camera2.SetActive (false);
	}
}
