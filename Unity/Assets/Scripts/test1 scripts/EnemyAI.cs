using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	//enemy have two states
	//patroling & chasing
	public float patrolSpeed = 2f;
	public float chaseSpeed = 5f;
	public float patrolWaitTime = 1f;
	public Transform[] patrolWayPoints;
	
	private NavMeshAgent nav;
	private Transform player;

	private float patrolTimer;
	private int wayPointIndex;

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
		nav.speed = chaseSpeed;
		nav.SetDestination (player.position);
	}

	void Patrolling(){
		nav.speed = patrolSpeed;

		if(nav.remainingDistance < nav.stoppingDistance){
			patrolTimer += Time.deltaTime;

			if(patrolTimer >= patrolWaitTime){
				if(wayPointIndex == patrolWayPoints.Length-1){
					wayPointIndex = 0;
				}
				else{
					wayPointIndex++;
				}

				patrolTimer = 0f;
			}
		}
		else
			patrolTimer = 0f;

		nav.SetDestination(patrolWayPoints[wayPointIndex].position);
	}
}
