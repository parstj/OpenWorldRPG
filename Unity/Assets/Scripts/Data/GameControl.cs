using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

	public static GameControl control;
	
	public PlayerData playerData = new PlayerData ();
	public OpenWorldData openWorldData = new OpenWorldData();
	public VillageData villageData = new VillageData();

	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if(control != this){
			Destroy(gameObject);
		}
	}

	public void Save(){
		if(Application.loadedLevel == 2){
			OpenWorldController.mySave (0, 0);
		}
		BinaryFormatter bf = new BinaryFormatter ();

		FileStream file = File.Create (Application.persistentDataPath + "/playerInfo.dat");
		bf.Serialize (file, playerData);
		file.Close ();

		file = File.Create (Application.persistentDataPath + "/openWorldInfo.dat");
		bf.Serialize (file, openWorldData);
		file.Close ();

		file = File.Create (Application.persistentDataPath + "/villageInfo.dat");
		bf.Serialize (file, villageData);
		file.Close ();
	}

	public void Load(){
		if (File.Exists (Application.persistentDataPath + "/playerInfo.dat") &&
		    File.Exists (Application.persistentDataPath + "/openWorldInfo.dat")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			playerData = (PlayerData)bf.Deserialize(file);
			file.Close();

			file = File.Open (Application.persistentDataPath + "/openWorldInfo.dat", FileMode.Open);
			openWorldData = (OpenWorldData)bf.Deserialize(file);
			file.Close();

			file = File.Open (Application.persistentDataPath + "/villageInfo.dat", FileMode.Open);
			villageData = (VillageData)bf.Deserialize(file);
			file.Close();
		}
	}

	public void NewGame(){
		playerData.level = 1;
		playerData.curHealth = 10;
		playerData.curEnergy = 10;
		playerData.curExperience = 0;
		playerData.curDamageMultiplier = 1;

		openWorldData.playerPosX = 2.0F;
		openWorldData.playerPosY = 1.0F;
		openWorldData.playerPosZ = 2.0F;
		openWorldData.enemy1.isDead = 0;
		openWorldData.enemy1.isPlayerInSight = false;
		openWorldData.enemy1.posX = 20.0F;
		openWorldData.enemy1.posY = 2.19F;
		openWorldData.enemy1.posZ = 20.0F;

		villageData.turn = 1;

		Save ();
	}
	
	void OnGUI(){
		GUI.Label (new Rect(200, 10, 150, 30), "Level: " + playerData.level);
		GUI.Label (new Rect(200, 30, 150, 30), "Health: " + playerData.curHealth);
		GUI.Label (new Rect(200, 50, 150, 30), "Energy: " + playerData.curEnergy);
		GUI.Label (new Rect(200, 70, 150, 30), "Experience: " + playerData.curExperience);
		GUI.Label (new Rect(200, 90, 150, 30), "DamageMultiplier: " + playerData.curDamageMultiplier);

		GUI.Label (new Rect(200, 110, 150, 30), "playerPosX: " + openWorldData.playerPosX);
		GUI.Label (new Rect(200, 130, 150, 30), "playerPosY: " + openWorldData.playerPosY);
		GUI.Label (new Rect(200, 150, 150, 30), "PlayerPosZ: " + openWorldData.playerPosZ);
		GUI.Label (new Rect(200, 170, 150, 30), "EnemyIsDead: " + openWorldData.enemy1.isDead);
		GUI.Label (new Rect(200, 190, 150, 30), "EnemyPosX: " + openWorldData.enemy1.posX);
		GUI.Label (new Rect(200, 210, 150, 30), "EnemyPosY: " + openWorldData.enemy1.posY);
		GUI.Label (new Rect(200, 230, 150, 30), "EnemyPosZ: " + openWorldData.enemy1.posZ);

		GUI.Label (new Rect (200, 250, 150, 30), "Turn: " + villageData.turn);
		GUI.Label (new Rect(200, 270, 150, 30), "EnemyisPlayerInSight: " + openWorldData.enemy1.isPlayerInSight);
	}
}

[Serializable]
public class PlayerData{
	public int level;
	public int curHealth;
	public int curEnergy;
	public int curExperience;
	public int curDamageMultiplier;
}
[Serializable]
public class OpenWorldData{
	public float playerPosX;
	public float playerPosY;
	public float playerPosZ;
	public EnemyData enemy1 = new EnemyData();
}
[Serializable]
public class EnemyData{
	public int isDead;
	public bool isPlayerInSight;
	public float posX;
	public float posY;
	public float posZ;
}
[Serializable]
public class VillageData{
	public int turn;
}
