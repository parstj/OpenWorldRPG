using UnityEngine;
using System.Collections;

public class Well : Building {

	public Well(int buildingType) : base(buildingType){}

	public override void applyBuildingEffects(ResourceManager resourceManager){
		resourceManager.Water = resourceManager.Water + this.Level;
	}
}
