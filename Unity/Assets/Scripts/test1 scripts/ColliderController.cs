using UnityEngine;
using System.Collections;

public class ColliderController: MonoBehaviour {
	public GameObject camera1;
	public GameObject camera2;
	public GameObject panel1;
	public GameObject panel2;
	public GameObject panel3;

	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "VillageTag") {
			OpenWorldController.mySave (0, 1);

			if (Application.CanStreamedLevelBeLoaded ("Village Management")) {
				GameControl.control.PlayBgm2();
				Application.LoadLevel ("Village Management");
			}
		} else if (other.gameObject.tag == "EnemyTag") {
			Debug.Log (other.name);
			OpenWorldController.mySave (1, 0);

			if (Application.CanStreamedLevelBeLoaded ("BoxCombat")) {
				Application.LoadLevel ("BoxCombat");
			}
		} else if (other.gameObject.tag == "FriendTag") {
			MeetFriend ();
		} else if (other.gameObject.tag == "NeutralTag") {
			MeetNeutral();
		}
	}

	void MeetFriend(){
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		
		//teleport player
		Transform newLoc = GameObject.Find ("FriendExit_001").transform;
		player.transform.position = newLoc.position;
		
		//switch camera
		camera1.SetActive (false);
		camera2.SetActive (true);

		//reinitialize panels
		panel1.SetActive (false);
		panel2.SetActive (false);
		panel3.SetActive (false);

		//mission finished
		if (GameControl.control.openWorldData.mission1.finished) {
			panel3.SetActive (true);
		} 
		//never started
		else if (!GameControl.control.openWorldData.mission1.started) {
			panel1.SetActive (true);
		} 
		//just finished
		else if (GameControl.control.openWorldData.enemy1.isDead == 1) {
			panel3.SetActive (true);
			GameControl.control.openWorldData.mission1.finished = true;
		}
		//not finisehd yet
		else {
			panel2.SetActive (true);
		}
	}

	void MeetNeutral(){
		Debug.Log ("MeetNeutral");

		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		Transform newLoc = GameObject.Find ("NeturalExit_001").transform;
		player.transform.position = newLoc.position;


	}
}
