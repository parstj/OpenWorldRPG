using UnityEngine;
using System.Collections;

public class EnemySight : MonoBehaviour {
	public float fieldOfViewAngle = 110f;
	public bool playerInSight;

	private NavMeshAgent nav;
	private SphereCollider col;
	private GameObject player;

	void Awake(){
		playerInSight = false;
		player = GameObject.FindGameObjectWithTag("Player");
		nav = GetComponent <NavMeshAgent> ();
		col = GetComponent <SphereCollider> ();
	}

	void Update(){
		
	}

	void OnTriggerStay(Collider other){
		if(other.gameObject == player && playerInSight == false){
			Vector3 direction = other.transform.position - transform.position;
			float angle = Vector3.Angle(direction, transform.forward);

			if(angle < fieldOfViewAngle * 0.5f){
				RaycastHit hit;
				//this is checking there is nothing blocking enemy's view
				if(Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, col.radius)){
					if(hit.collider.gameObject == player){
						playerInSight = true;
					}
				}
			}
		}
	}
}