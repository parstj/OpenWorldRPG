using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResourceManager: MonoBehaviour {
	public int Gold { get; set; }
	public int Food { get; set; }
	public int Water { get; set; }
	public int Wood { get; set; }
	public int Stone { get; set; }
	public int CurrentPop { get; set; }
	public int MaxPop { get; set; }

	#region updateDisplays
	public UnityEngine.UI.Text goldDisplay; 
	public UnityEngine.UI.Text foodDisplay;
	public UnityEngine.UI.Text waterDisplay;
	public UnityEngine.UI.Text woodDisplay;
	public UnityEngine.UI.Text stoneDisplay;
	public UnityEngine.UI.Text currentPopDisplay;
	public UnityEngine.UI.Text maxPopDisplay;
	
	public void updateAllDisplays(){
		updateGoldDisplay ();
		updateFoodDisplay ();
		updateWaterDisplay ();
		updateWoodDisplay ();
		updateStoneDisplay ();
		updateCurrentPopDisplay ();
		updateMaxPopDisplay ();
	}
	
	private void updateGoldDisplay(){
		goldDisplay.text = Gold.ToString ();
	}
	
	private void updateFoodDisplay(){
		foodDisplay.text = Food.ToString ();
		if (Food < 10) {
			foodDisplay.color = Color.red; 
		}
		else{
			foodDisplay.color = Color.black;
		}
	}
	
	private void updateWaterDisplay(){
		waterDisplay.text = Water.ToString ();
		if (Water < 10) {
			waterDisplay.color = Color.red; 
		}
		else{
			waterDisplay.color = Color.black;
		}
	}
	
	private void updateWoodDisplay(){
		woodDisplay.text = Wood.ToString ();
	}
	
	private void updateStoneDisplay(){
		stoneDisplay.text = Stone.ToString ();
	}
	
	private void updateCurrentPopDisplay(){
		currentPopDisplay.text = CurrentPop.ToString ();
	}
	
	private void updateMaxPopDisplay(){
		maxPopDisplay.text = " / " + MaxPop.ToString ();
	}
	#endregion



	void Start(){
		Gold = 0;
		Food = 0;
		Water = 0;
		Wood = 0;
		Stone = 0;
		CurrentPop = 2;
		MaxPop = 5;

		updateAllDisplays();
	}
}
