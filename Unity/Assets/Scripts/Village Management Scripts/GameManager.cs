using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
	
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
		//Checks to see if the population can be increased
		if (resources.CurrentPop < resources.MaxPop) {
			//Checks to see if there is enough water available
			if(buildingManager.Buildings[0].Level > (resources.CurrentPop + buildingManager.Buildings[1].Level)){
				//Checks to see if there is enough food available
				if((buildingManager.Buildings[1].Level * 2) > resources.CurrentPop){
					resources.CurrentPop++;
				}
			}
		}
		resources.updateAllDisplays();
	}

	public bool checkResources(int index){
		int level = buildingManager.Buildings [index].Level;
		float costModifier = buildingManager.Buildings [index].CostModifier;

		int cost = Mathf.CeilToInt (level * costModifier);

		if(resources.Wood < cost || resources.Stone < cost){
			return false;
		}
		else{
			resources.Wood -= cost;
			resources.Stone -= cost;
			return true;
		}
	}
	#endregion
}
