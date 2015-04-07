using UnityEngine;
using System.Collections;

public class VillageCollider: MonoBehaviour {
	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "VillageTag") {
			if (Application.CanStreamedLevelBeLoaded ("Village Management")) {
				Application.LoadLevel ("Village Management");
			}
		} else if (other.gameObject.tag == "EnemyTag") {
			Debug.Log("HERE");
			if (Application.CanStreamedLevelBeLoaded ("BoxCombat")){
				Application.LoadLevel ("BoxCombat");
			}
		}
	}
}
