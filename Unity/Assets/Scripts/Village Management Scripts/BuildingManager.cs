using UnityEngine;
using System.Collections.Generic;

public class BuildingManager: MonoBehaviour{
	public GameManager gameManager;

	public const int WELL_INDEX = 0;
	public const int FARM_INDEX = 1;
	public const int WOODCUTTER_INDEX = 2;
	public const int STONEMASON_INDEX = 3;
	public const int HOUSE_INDEX = 4;

	public UnityEngine.UI.Text wellLevel;
	public UnityEngine.UI.Text farmLevel;
	public UnityEngine.UI.Text woodcutterLevel;
	public UnityEngine.UI.Text stonemasonLevel;
	public UnityEngine.UI.Text houseLevel;

	public UnityEngine.UI.Text wellCost;
	public UnityEngine.UI.Text farmCost;
	public UnityEngine.UI.Text woodcutterCost;
	public UnityEngine.UI.Text stonemasonCost;
	public UnityEngine.UI.Text houseCost;

	private string cost;

	public List<Building> Buildings {
		get;
		set;
	}

	void Start(){
		Buildings = new List<Building>();

		Well newWell = new Well (WELL_INDEX);
		Buildings.Add(newWell);
		wellLevel.text = "Level: " + Buildings[WELL_INDEX].Level.ToString();
		cost =  Mathf.CeilToInt (newWell.Level * newWell.CostModifier).ToString();
		cost = Mathf.CeilToInt (newWell.Level * newWell.CostModifier).ToString();
		wellCost.text = "Cost to Build: " + cost + " Wood and " + cost + " Stone";

		Farm newFarm = new Farm (FARM_INDEX);
		Buildings.Add(newFarm);
		farmLevel.text = "Level: " + Buildings[FARM_INDEX].Level.ToString();
		cost = Mathf.CeilToInt (newFarm.Level * newFarm.CostModifier).ToString();
		farmCost.text = "Cost to Build: " + cost + " Wood and " + cost + " Stone";

		Woodcutter newWoodcutter = new Woodcutter (WOODCUTTER_INDEX);
		Buildings.Add(newWoodcutter);
		woodcutterLevel.text = "Level: " + Buildings[WOODCUTTER_INDEX].Level.ToString();
		cost = Mathf.CeilToInt (newWoodcutter.Level * newWell.CostModifier).ToString();
		woodcutterCost.text = "Cost to Build: " + cost + " Wood and " + cost + " Stone";

		Stonemason newStonemason = new Stonemason (STONEMASON_INDEX);
		Buildings.Add(newStonemason);
		stonemasonLevel.text = "Level: " + Buildings[STONEMASON_INDEX].Level.ToString();
		cost = Mathf.CeilToInt (newStonemason.Level * newStonemason.CostModifier).ToString();
		stonemasonCost.text = "Cost to Build: " + cost + " Wood and " + cost + " Stone";

		House newHouse = new House (HOUSE_INDEX);
		Buildings.Add(newHouse);
		houseLevel.text = "Level: " + Buildings[HOUSE_INDEX].Level.ToString();
		cost = Mathf.CeilToInt (newHouse.Level * newHouse.CostModifier).ToString();
		houseCost.text = "Cost to Build: " + cost + " Wood and " + cost + " Stone";
	}
	
	public void levelUpWell(){
		if (gameManager.checkResources (WELL_INDEX)) {
			Buildings [WELL_INDEX].levelUp ();
			wellLevel.text = "Level: " + Buildings [WELL_INDEX].Level.ToString ();
			cost = Mathf.CeilToInt (Buildings [WELL_INDEX].Level * Buildings [WELL_INDEX].CostModifier).ToString();
			wellCost.text = "Cost to Build: " + cost + " Wood and " + cost + " Stone";
			gameManager.resources.updateAllDisplays();
		}
	}

	public void levelUpFarm(){
		if (gameManager.checkResources (FARM_INDEX)) {
			Buildings [FARM_INDEX].levelUp ();
			farmLevel.text = "Level: " + Buildings [FARM_INDEX].Level.ToString ();
			cost = Mathf.CeilToInt (Buildings [FARM_INDEX].Level * Buildings [FARM_INDEX].CostModifier).ToString();
			farmCost.text = "Cost to Build: " + cost + " Wood and " + cost + " Stone";
			gameManager.resources.updateAllDisplays();
		}
	}

	public void levelUpWoodcutter(){
		if (gameManager.checkResources (FARM_INDEX)) {
			Buildings[WOODCUTTER_INDEX].levelUp();
			woodcutterLevel.text = "Level: " + Buildings[WOODCUTTER_INDEX].Level.ToString();
			cost = Mathf.CeilToInt (Buildings [WOODCUTTER_INDEX].Level * Buildings [WOODCUTTER_INDEX].CostModifier).ToString();
			woodcutterCost.text = "Cost to Build: " + cost + " Wood and " + cost + " Stone";
			gameManager.resources.updateAllDisplays();
		}
	}

	public void levelUpStonemason(){
		if (gameManager.checkResources (FARM_INDEX)) {
			Buildings [STONEMASON_INDEX].levelUp ();
			stonemasonLevel.text = "Level: " + Buildings [STONEMASON_INDEX].Level.ToString ();
			cost = Mathf.CeilToInt (Buildings [STONEMASON_INDEX].Level * Buildings [STONEMASON_INDEX].CostModifier).ToString();
			stonemasonCost.text = "Cost to Build: " + cost + " Wood and " + cost + " Stone";
			gameManager.resources.updateAllDisplays();
		}
	}

	public void levelUpHouse(){
		if (gameManager.checkResources (FARM_INDEX)) {
			Buildings[HOUSE_INDEX].levelUp();
			houseLevel.text = "Level: " + Buildings[HOUSE_INDEX].Level.ToString();
			cost = Mathf.CeilToInt (Buildings [STONEMASON_INDEX].Level * Buildings [STONEMASON_INDEX].CostModifier).ToString();
			houseCost.text = "Cost to Build: " + cost + " Wood and " + cost + " Stone";
			gameManager.resources.updateAllDisplays();
		}
	}
}
