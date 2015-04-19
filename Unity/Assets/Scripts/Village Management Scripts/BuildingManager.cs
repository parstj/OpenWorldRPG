using UnityEngine;
using System.Collections.Generic;

public class BuildingManager: MonoBehaviour{
	public const int WELL_INDEX = 1;
	public List<Building> buildings2;

	public List<Building> Buildings {
		get;
		set;
	}

	public void buildWell(){
		Well newWell = new Well (WELL_INDEX);
		Buildings.Add(newWell);
	}

	void Start(){
		Buildings = new List<Building>();
	}
}
