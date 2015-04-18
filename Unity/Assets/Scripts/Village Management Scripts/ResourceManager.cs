using UnityEngine;
using System.Collections;

public class ResourceManager {
	public static int Gold { get; set; };
	public UnityEngine.UI.Text goldDisplay; 

	public static int Food { get; set; };
	public UnityEngine.UI.Text foodDisplay;

	public static int Water { get; set; };
	public UnityEngine.UI.Text waterDisplay;

	public static int Wood { get; set; };
	public UnityEngine.UI.Text woodDisplay;

	public static int Stone { get; set; };
	public UnityEngine.UI.Text stoneDisplay;

	public static int CurrentPop { get; set; };
	public UnityEngine.UI.Text currentPopDisplay;

	public static int MaxPop { get; set; };
	public UnityEngine.UI.Text maxPopDisplay;

	#region updateDisplays
	public static void updateAllDisplays(){
		updateGoldDisplay ();
		updateFoodDisplay ();
		updateWaterDisplay ();
		updateWoodDisplay ();
		updateStoneDisplay ();
		updateCurrentPopDisplay ();
		updateMaxPopDisplay ();
	}

	private void updateGoldDisplay(){
		goldDisplay.text = gold.ToString ();
	}

	private void updateFoodDisplay(){
		foodDisplay.text = food.ToString ();
		if (food < 10) {
			foodDisplay.color = Color.red; 
		}
	}

	private void updateWaterDisplay(){
		waterDisplay.text = water.ToString ();
		if (water < 10) {
			waterDisplay.color = Color.red; 
		}
	}

	private void updateWoodDisplay(){
		woodDisplay.text = wood.ToString ();
	}
	
	private void updateStoneDisplay(){
		stoneDisplay.text = stone.ToString ();
	}

	private void updateCurrentPopDisplay(){
		currentPopDisplay.text = currentPop.ToString ();
	}

	private void updateMaxPopDisplay(){
		maxPopDisplay.text = " / " + maxPop.ToString ();
	}
	#endregion
}
