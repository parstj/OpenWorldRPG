using UnityEngine;
using System.Collections;

public abstract class Building {
	
	public int buildingType {
		get;
		set;
	}

	public Building(int buildingType){
		this.buildingType = buildingType;
	}

	protected enum Resources { gold, food, water, wood, stone, currPop, maxPop };
	
	public string Name { get; set; }
	public int Level { get; set; }
	
	public abstract void applyBuildingEffects(ResourceManager resourceManager);

}
