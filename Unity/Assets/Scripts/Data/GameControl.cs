using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

	public static GameControl control;


	//player data
	public int level;
	public int curHealth;
	public int curEnergy;
	public int curExperience;
	public int curDamageMultiplier;

	//village information
	
	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if(control != this){
			Destroy(gameObject);
		}
	}

	public void Save(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfo.dat");

		PlayerData data = new PlayerData ();
		data.level = level;
		data.curHealth = curHealth;
		data.curEnergy = curEnergy;
		data.curExperience = curExperience;
		data.curDamageMultiplier = curDamageMultiplier;

		bf.Serialize (file, data);
		file.Close ();
	}

	public void Load(){
		if (File.Exists (Application.persistentDataPath + "/playerInfo.dat")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);

			PlayerData data = (PlayerData)bf.Deserialize(file);
			file.Close();

			level = data.level;
			curHealth = data.curHealth;
			curEnergy = data.curEnergy;
			curExperience = data.curExperience;
			curDamageMultiplier = data.curDamageMultiplier;
		}
	}

	public void NewGame(){
		level = 1;
		curHealth = 10;
		curEnergy = 10;
		curExperience = 0;
		curDamageMultiplier = 1;

		Save ();
	}
	
	void OnGUI(){
		GUI.Label (new Rect(200, 10, 150, 30), "Level: " + level);
		GUI.Label (new Rect(200, 40, 150, 30), "Health: " + curHealth);
		GUI.Label (new Rect(200, 70, 150, 30), "Energy: " + curEnergy);
		GUI.Label (new Rect(200, 100, 150, 30), "Experience: " + curExperience);
		GUI.Label (new Rect(200, 130, 150, 30), "DamageMultiplier: " + curDamageMultiplier);
	}
}

[Serializable]
class PlayerData{
	public int level;
	public int curHealth;
	public int curEnergy;
	public int curExperience;
	public int curDamageMultiplier;
}