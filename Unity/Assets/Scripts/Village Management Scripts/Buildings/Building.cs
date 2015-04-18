using UnityEngine;
using System.Collections;

public class Building {

	protected enum Resources { gold, food, water, wood, stone, currPop, maxPop };

	public string Name { get; };
	public string Level { get; set; };
}
