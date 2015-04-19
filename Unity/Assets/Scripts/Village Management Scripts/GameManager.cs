using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public int Turns { get; set; }
	public List<Building> buildings;
	ResourceManager resources;
	
	// Use this for initialization
	void Start () {
		initializeResourceManager ();
		buildings = new List<Building> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void EndTurn(){
		Turns++;
	}

	private void initializeResourceManager(){
		resources = new ResourceManager ();

		resources.Gold = 0;
		resources.Food = 0;
		resources.Water = 0;
		resources.Wood = 0;
		resources.Stone = 0;
		resources.CurrentPop = 0;
		resources.MaxPop = 10;

		updateAllDisplays (resources);
	}

	private void buildingsEndTurn(){
		foreach(Building b in buildings){
			b.applyBuildingEffects(resources);
		}
		updateAllDisplays (resources);
	}

	#region updateDisplays
	public static void updateAllDisplays(ResourceManager resources){
		updateGoldDisplay (resources);
		updateFoodDisplay (resources);
		updateWaterDisplay (resources);
		updateWoodDisplay (resources);
		updateStoneDisplay (resources);
		updateCurrentPopDisplay (resources);
		updateMaxPopDisplay (resources);
	}
	
	private static void updateGoldDisplay(ResourceManager resources){
		resources.goldDisplay.text = resources.Gold.ToString ();
	}
	
	private static void updateFoodDisplay(ResourceManager resources){
		resources.foodDisplay.text = resources.Food.ToString ();
		if (resources.Food < 10) {
			resources.foodDisplay.color = Color.red; 
		}
	}
	
	private static void updateWaterDisplay(ResourceManager resources){
		resources.waterDisplay.text = resources.Water.ToString ();
		if (resources.Water < 10) {
			resources.waterDisplay.color = Color.red; 
		}
	}
	
	private static void updateWoodDisplay(ResourceManager resources){
		resources.woodDisplay.text = resources.Wood.ToString ();
	}
	
	private static void updateStoneDisplay(ResourceManager resources){
		resources.stoneDisplay.text = resources.Stone.ToString ();
	}
	
	private static void updateCurrentPopDisplay(ResourceManager resources){
		resources.currentPopDisplay.text = resources.CurrentPop.ToString ();
	}
	
	private static void updateMaxPopDisplay(ResourceManager resources){
		resources.maxPopDisplay.text = " / " + resources.MaxPop.ToString ();
	}
	#endregion
}
