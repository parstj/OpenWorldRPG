using UnityEngine;
using System.Collections;

public class Farm : Building {
	
	public Farm(int buildingType) : base(buildingType){
		this.Name = "Farm";
	}
	
	public override void applyBuildingEffects(ResourceManager resourceManager){
		resourceManager.Food = resourceManager.Food + (this.Level * 2);
		resourceManager.Water = resourceManager.Water - this.Level;
	}
}
