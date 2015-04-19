using UnityEngine;
using System.Collections;

public class ResourceManager {
	public int Gold { get; set; }
	public UnityEngine.UI.Text goldDisplay; 

	public int Food { get; set; }
	public UnityEngine.UI.Text foodDisplay;

	public int Water { get; set; }
	public UnityEngine.UI.Text waterDisplay;

	public int Wood { get; set; }
	public UnityEngine.UI.Text woodDisplay;

	public int Stone { get; set; }
	public UnityEngine.UI.Text stoneDisplay;

	public int CurrentPop { get; set; }
	public UnityEngine.UI.Text currentPopDisplay;

	public int MaxPop { get; set; }
	public UnityEngine.UI.Text maxPopDisplay;
}
