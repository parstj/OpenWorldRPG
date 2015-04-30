using UnityEngine;
using System.Collections;

public class Well : Building {

	public Well(int buildingType) : base(buildingType){
		this.Name = "Well";
		this.CostModifier = 1.0f;
	}

	public override void applyBuildingEffects(ResourceManager resourceManager){
		resourceManager.Water = resourceManager.Water + this.Level;
	}
}
