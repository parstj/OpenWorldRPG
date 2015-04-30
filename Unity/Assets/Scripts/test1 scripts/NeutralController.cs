using UnityEngine;
using System.Collections;

public class NeutralController : MonoBehaviour {
	public GameObject camera1;
	public GameObject camera2;
	public GameObject panel1;
	public GameObject panel2;
	public GameObject panel3;

	public void Accept(){
		GameControl.control.villageData.gold = 0;
		panel1.SetActive (false);
		panel2.SetActive (true);
	}

	public void Refuse(){
		panel1.SetActive (false);
		panel3.SetActive (true);
	}

	public void FinishAccept(){
		camera2.SetActive (false);
		camera1.SetActive (true);

		panel2.SetActive (false);
	}

	public void FinishRefuse(){
		camera2.SetActive (false);
		camera1.SetActive (true);

		GameControl.control.openWorldData.neutral1.isEnemy = true;

		panel3.SetActive (false);
	}
}
