using UnityEngine;
using System.Collections;

public class ColliderController: MonoBehaviour {
	public GameObject mainCamera;
	public GameObject friendCamera;
	public GameObject neutralCamera;

	public GameObject friendPanel1;
	public GameObject friendPanel2;
	public GameObject friendPanel3;
	public GameObject neutralPanel1;
	public GameObject neutralPanel2;
	public GameObject neutralPanel3;

	public GameObject trapPoint;

	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "VillageTag") {
			OpenWorldController.mySave (0, 1, 0);

			if (Application.CanStreamedLevelBeLoaded ("Village Management")) {
				GameControl.control.PlayBgm4();
				Application.LoadLevel ("Village Management");
			}
		} else if (other.gameObject.tag == "EnemyTag") {
			GameControl.control.openWorldData.enemyType = 1;
			Debug.Log (other.name);
			OpenWorldController.mySave (1, 0, 0);

			if (Application.CanStreamedLevelBeLoaded ("BoxCombat")) {
				GameControl.control.PlayBgm3();
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
		
		//switch camera
		mainCamera.SetActive (false);
		friendCamera.SetActive (true);
		//teleport player
		player.transform.position = trapPoint.transform.position;

		//reinitialize panels
		friendPanel1.SetActive (false);
		friendPanel2.SetActive (false);
		friendPanel3.SetActive (false);

		//mission finished
		if (GameControl.control.openWorldData.mission1.finished) {
			friendPanel3.SetActive (true);
		} 
		//never started
		else if (!GameControl.control.openWorldData.mission1.started) {
			friendPanel1.SetActive (true);
		} 
		//just finished
		else if (GameControl.control.openWorldData.enemy1.isDead == 1) {
			friendPanel3.SetActive (true);
			GameControl.control.openWorldData.mission1.finished = true;
		}
		//not finisehd yet
		else {
			friendPanel2.SetActive (true);
		}
	}

	void MeetNeutral(){
		Debug.Log ("MeetNeutral");

		if (!GameControl.control.openWorldData.neutral1.isEnemy) {
			//teleport player
			GameObject player = GameObject.FindGameObjectWithTag ("Player");

			//switch camera
			mainCamera.SetActive (false);
			neutralCamera.SetActive (true);
			//teleport player
			player.transform.position = trapPoint.transform.position;
			
			//reinitialize panels
			neutralPanel1.SetActive (false);
			neutralPanel2.SetActive (false);
			neutralPanel3.SetActive (false);

			neutralPanel1.SetActive (true);

		} else {
			GameControl.control.openWorldData.enemyType = 2;
			OpenWorldController.mySave (0, 0, 1);
			if (Application.CanStreamedLevelBeLoaded ("BoxCombat")) {
				GameControl.control.PlayBgm3();
				Application.LoadLevel ("BoxCombat");
			}
		}
	}
}
