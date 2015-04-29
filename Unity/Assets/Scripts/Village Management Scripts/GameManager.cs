using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public UnityEngine.UI.Text hello2;
	public int hello;
	public int Turns { get; set; }
	public BuildingManager buildingManager;
	public ResourceManager resources;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	#region endTurn
	public void EndTurn(){
		buildingsEndTurn ();
		Turns++;
	}
	
	private void buildingsEndTurn(){
		foreach(Building b in buildingManager.Buildings){
			b.applyBuildingEffects(resources);
		}
		resources.updateAllDisplays();
	}
	#endregion

	#region buttonClicks
	public void buildWell(){
		
	}
	#endregion


}
