using UnityEngine;
using System.Collections;

public class LeaveVillageButton : MonoBehaviour {

	public void leaveVillageButtonClick(){
		if(Application.CanStreamedLevelBeLoaded("test1")){
			Application.LoadLevel ("test1");
		}
	}
}
