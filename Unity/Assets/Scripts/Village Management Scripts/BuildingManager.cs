using UnityEngine;
using System.Collections.Generic;

public class BuildingManager: MonoBehaviour{
	public const int WELL_INDEX = 0;
	public const int FARM_INDEX = 1;

	public UnityEngine.UI.Text wellLevel;
	public UnityEngine.UI.Text farmLevel;

	public List<Building> Buildings {
		get;
		set;
	}

	void Start(){
		Buildings = new List<Building>();

		Well newWell = new Well (WELL_INDEX);
		Buildings.Add(newWell);
		wellLevel.text = "Level: " + Buildings[WELL_INDEX].Level.ToString();

		Farm newFarm = new Farm (FARM_INDEX);
		Buildings.Add(newFarm);
		farmLevel.text = "Level: " + Buildings[FARM_INDEX].Level.ToString();
	}
	
	public void levelUpWell(){
		Buildings[WELL_INDEX].levelUp();
		wellLevel.text = "Level: " + Buildings[WELL_INDEX].Level.ToString();
	}

	public void levelUpFarm(){
		Buildings[FARM_INDEX].levelUp();
		farmLevel.text = "Level: " + Buildings[FARM_INDEX].Level.ToString();
	}
}
