using UnityEngine;
using System.Collections;

public class LeaveVillageButton : MonoBehaviour {

	public void leaveVillageButtonClick(){
		if(Application.CanStreamedLevelBeLoaded("OpenWorld")){
			Application.LoadLevel ("OpenWorld");
		}
	}
}
