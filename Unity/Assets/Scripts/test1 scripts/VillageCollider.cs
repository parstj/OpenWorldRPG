using UnityEngine;
using System.Collections;

public class VillageCollider: MonoBehaviour {
	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "VillageTag") {
			OpenWorldController.mySave(0, 1);

			if (Application.CanStreamedLevelBeLoaded ("Village Management")) {
				Application.LoadLevel ("Village Management");
			}
		} else if (other.gameObject.tag == "EnemyTag") {
			Debug.Log (other.name);
			OpenWorldController.mySave(1, 0);

			Debug.Log("HERE");
			if (Application.CanStreamedLevelBeLoaded ("BoxCombat")){
				Application.LoadLevel ("BoxCombat");
			}
		} else if(other.gameObject.tag == "FriendTag"){

		}
	}
}
