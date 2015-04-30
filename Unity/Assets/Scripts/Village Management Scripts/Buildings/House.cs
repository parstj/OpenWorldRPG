using UnityEngine;
using System.Collections;

public class House : Building {

	public House(int buildingType) : base(buildingType){
		this.Name = "House";
		this.CostModifier = 2.0f;
	}
	
	public override void applyBuildingEffects(ResourceManager resourceManager){
		resourceManager.MaxPop = this.Level * 5;
	}
}
