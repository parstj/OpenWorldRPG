using UnityEngine;
using System.Collections;

public class NeutralAI : MonoBehaviour {
	public float chaseSpeed = 3f;

	private NavMeshAgent nav;
	private Transform player;

	void Awake(){
		player = GameObject.FindGameObjectWithTag("Player").transform;
		nav = GetComponent <NavMeshAgent> ();
	}

	void Update(){
		if(GameControl.control.openWorldData.neutral1.isEnemy){
			Chasing ();
		}
	}

	void Chasing(){
		nav.speed = chaseSpeed;
		nav.SetDestination (player.position);
	}
}
