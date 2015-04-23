using UnityEngine;
using System.Collections;

public class OpenWorldController : MonoBehaviour {

	GameObject player;
	GameObject enemy1;

	// Use this for initialization
	void Awake () {
		myLoad ();
	}
	
	void myLoad(){
		//initializing
		player = GameObject.Find ("Player");
		enemy1 = GameObject.Find ("Enemy1Body");


		//player load
		Vector3 playerPos = new Vector3(GameControl.control.openWorldData.playerPosX,
		                                GameControl.control.openWorldData.playerPosY,
		                                GameControl.control.openWorldData.playerPosZ);
		player.transform.position = playerPos;
		

		//enemy load
		if (GameControl.control.openWorldData.enemy1.isDead == 0) {
			Vector3 enemyPos = new Vector3 (GameControl.control.openWorldData.enemy1.posX,
			                               GameControl.control.openWorldData.enemy1.posY,
			                               GameControl.control.openWorldData.enemy1.posZ);
			enemy1.transform.position = enemyPos;
		} else {
			enemy1.SetActive(false);
		}
	}

	public static void mySave(int enemyIsKilled){
		//initializing
		GameObject player = GameObject.Find ("Player");
		GameObject enemy1 = GameObject.Find ("Enemy1Body");


		//player save
		GameControl.control.openWorldData.playerPosX = player.transform.position.x;
		GameControl.control.openWorldData.playerPosY = player.transform.position.y;
		GameControl.control.openWorldData.playerPosZ = player.transform.position.z;


		//enemy save
		if(enemyIsKilled == 1)// 1 means it is killed, 0 means not changed
			GameControl.control.openWorldData.enemy1.isDead = 1;
		if (GameControl.control.openWorldData.enemy1.isDead == 0) {//enemy is still alive
			GameControl.control.openWorldData.enemy1.posX = enemy1.transform.position.x;
			GameControl.control.openWorldData.enemy1.posY = enemy1.transform.position.y;
			GameControl.control.openWorldData.enemy1.posZ = enemy1.transform.position.z;
		}
	}
}
