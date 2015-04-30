using UnityEngine;
using System.Collections;

public class Stonemason : Building {
	
	public Stonemason(int buildingType) : base(buildingType){
		this.Name = "Stonemason";
		this.CostModifier = 1.5f;
	}
	
	public override void applyBuildingEffects(ResourceManager resourceManager){
		resourceManager.Stone += Mathf.FloorToInt((resourceManager.CurrentPop / 2) * this.Level);
	}
}
