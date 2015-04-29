using UnityEngine;
using System.Collections;

public class Woodcutter : Building {
	
	public Woodcutter(int buildingType) : base(buildingType){
		this.Name = "Woodcutter";
	}
	
	public override void applyBuildingEffects(ResourceManager resourceManager){
		resourceManager.Wood += Mathf.FloorToInt((resourceManager.CurrentPop / 2) * this.Level);
	}
}
