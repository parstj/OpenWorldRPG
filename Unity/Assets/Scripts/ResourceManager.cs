using UnityEngine;
using System.Collections;

public class ResourceManager : MonoBehaviour {
	private int gold;
	public UnityEngine.UI.Text goldDisplay; 

	private int food;
	public UnityEngine.UI.Text foodDisplay;

	private int water;
	public UnityEngine.UI.Text waterDisplay;

	private int wood;
	public UnityEngine.UI.Text woodDisplay;

	private int stone;
	public UnityEngine.UI.Text stoneDisplay;

	private int currentPop;
	public UnityEngine.UI.Text currentPopDisplay;

	private int maxPop;
	public UnityEngine.UI.Text maxPopDisplay;

	// Use this for initialization
	void Start () {
		gold = 0;
		food = 0;
		water = 0;
		wood = 0;
		stone = 0;
		currentPop = 0;
		maxPop = 10;

		updateAllDisplays ();
	}
	
	// Update is called once per frame
	void Update () {
		modifyFood (1);
	}

	#region updateDisplays
	private void updateAllDisplays(){
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

	#region modifyResourceValues
	public void modifyGold(int amount){
		gold += amount;
		if (gold < 0) {
			gold = 0;
		}
		updateGoldDisplay ();
	}

	public void modifyFood(int amount){
		food += amount;
		if (food < 0) {
			food = 0;
		}
		updateFoodDisplay ();
	}

	public void modifyWater(int amount){
		water += amount;
		if (water < 0) {
			water = 0;
		}
		updateWaterDisplay ();
	}

	public void modifyWood(int amount){
		wood += amount;
		if (wood < 0) {
			wood = 0;
		}
		updateWoodDisplay ();
	}

	public void modifyStone(int amount){
		stone += amount;
		if (stone < 0) {
			stone = 0;
		}
		updateStoneDisplay ();
	}

	public void modifyCurrentPop(int amount){
		currentPop += amount;
		if (currentPop < 0) {
			currentPop = 0;
		}
		updateCurrentPopDisplay ();
	}

	public void modifyMaxPop(int amount){
		maxPop += amount;
		if(maxPop < 0){
			maxPop = 0;
		}
		updateMaxPopDisplay ();
	}
	#endregion
}
