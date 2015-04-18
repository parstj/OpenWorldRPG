using UnityEngine;
using System.Collections;

public class Well : Building {

	public void applyEffects(){
		ResourceManager.Water = ResourceManager.Water + this.Level;
	}
}
