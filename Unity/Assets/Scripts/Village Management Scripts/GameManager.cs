using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public int Turns { get; set; };




	// Use this for initialization
	void Start () {
		initializeResourceManager ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void EndTurn(){
		Turns++;
	}

	private void initializeResourceManager(){
		ResourceManager.Gold = 0;
		ResourceManager.Food = 0;
		ResourceManager.Water = 0;
		ResourceManager.Wood = 0;
		ResourceManager.Stone = 0;
		ResourceManager.CurrentPop = 0;
		ResourceManager.MaxPop = 10;

		ResourceManager.updateAllDisplays ();
	}
}
