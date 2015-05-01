using UnityEngine;
using System.Collections;

public class FriendControl : MonoBehaviour {
	public GameObject camera1;
	public GameObject camera2;

	public GameObject panel1;
	public GameObject panel2;
	public GameObject panel3;

	public GameObject returnPoint;
	public GameObject player;

	public void Accept(){
		panel1.SetActive (false);

		GameControl.control.openWorldData.mission1.started = true;
		player.transform.position = returnPoint.transform.position;
		camera1.SetActive (true);
		camera2.SetActive (false);
	}

	public void Refuse(){
		panel1.SetActive (false);
		panel2.SetActive (false);
		panel3.SetActive (false);

		player.transform.position = returnPoint.transform.position;
		camera1.SetActive (true);
		camera2.SetActive (false);
	}
}
