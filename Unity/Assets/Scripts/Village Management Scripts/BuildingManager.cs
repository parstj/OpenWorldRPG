using UnityEngine;
using System.Collections.Generic;

public class BuildingManager {
	public const int WELL_INDEX = 1;
	public static List<Building> buildWell(List<Building> buildings){
		Well newWell = new Well (WELL_INDEX);
		buildings.Add(newWell);
		return buildings;
	}
}
