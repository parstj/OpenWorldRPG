using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	//enemy have two states
	//patroling & chasing
	public float patrolSpeed = 2f;
	public float chaseSpeed = 5f;
	public float chaseWaitTime = 5f;
	public float patrolWaitTime = 1f;
	public Transform[] patrolWayPoints;
	
	private NavMeshAgent nav;
	private Transform player;

	private float chaseTimer;
	private float patrolTimer;
	private float wayPointIndex;

	void Awake(){
		player = GameObject.FindGameObjectWithTag("Player").transform;
		nav = GetComponent <NavMeshAgent> ();
	}

	void Update(){
		if(GameControl.control.openWorldData.enemy1.isPlayerInSight){
			Chasing ();
		} else {
			Patrolling();
		}
	}

	void Chasing(){
		nav.SetDestination (player.position);
	}

	void Patrolling(){
		//nav.SetDestination (player.position);
	}
}
