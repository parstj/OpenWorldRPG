using UnityEngine;
using System.Collections;

public class EnemySight : MonoBehaviour {
	private GameObject player;

	void Awake(){
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject == player && GameControl.control.openWorldData.enemy1.isPlayerInSight == false){
			GameControl.control.openWorldData.enemy1.isPlayerInSight = true;
		}
	}
}