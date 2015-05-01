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
	public MissionData missionData = new MissionData();

	public AudioSource bgm1;
	public AudioSource bgm2;
	public AudioSource bgm3;
	public AudioSource bgm4;

	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if(control != this){
			Destroy(gameObject);
		}
	}

	public void PlayBgm1(){
		if(bgm2.isPlaying)
			bgm2.Stop ();
		if (bgm3.isPlaying)
			bgm3.Stop ();
		if (bgm4.isPlaying)
			bgm4.Stop ();
		if(!bgm1.isPlaying)
			bgm1.Play ();
	}
	public void PlayBgm2(){
		if(bgm1.isPlaying)
			bgm1.Stop ();
		if (bgm3.isPlaying)
			bgm3.Stop ();
		if (bgm4.isPlaying)
			bgm4.Stop ();
		if(!bgm2.isPlaying)
			bgm2.Play ();
	}
	public void PlayBgm3(){
		if(bgm1.isPlaying)
			bgm1.Stop ();
		if (bgm2.isPlaying)
			bgm2.Stop ();
		if (bgm4.isPlaying)
			bgm4.Stop ();
		if(!bgm3.isPlaying)
			bgm3.Play ();
	}
	public void PlayBgm4(){
		if(bgm1.isPlaying)
			bgm1.Stop ();
		if (bgm2.isPlaying)
			bgm2.Stop ();
		if (bgm3.isPlaying)
			bgm3.Stop ();
		if(!bgm4.isPlaying)
			bgm4.Play ();
	}

	public void Save(){
		if(Application.loadedLevel == 2){
			OpenWorldController.mySave (0, 0, 0);
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

		openWorldData.turn = 1;
		openWorldData.playerPosX = 8.0F;
		openWorldData.playerPosY = 2.0F;
		openWorldData.playerPosZ = 9.0F;
		openWorldData.enemyType = 0;
		openWorldData.enemy1.isDead = 0;
		openWorldData.enemy1.isPlayerInSight = false;
		openWorldData.enemy1.posX = 26.0F;
		openWorldData.enemy1.posY = 1.0F;
		openWorldData.enemy1.posZ = 23.0F;
		openWorldData.mission1.started = false;
		openWorldData.mission1.finished = false;
		openWorldData.neutral1.isDead = 0;
		openWorldData.neutral1.isEnemy = false;
		openWorldData.neutral1.posX = 16.0F;
		openWorldData.neutral1.posY = 0.0F;
		openWorldData.neutral1.posZ = 49.0F;

		villageData.lvl_building1 = 1;
		villageData.lvl_building2 = 1;
		villageData.lvl_building3 = 1;
		villageData.lvl_building4 = 1;
		villageData.lvl_building5 = 1;
		//resources
		villageData.gold = 0;
		villageData.food = 0;
		villageData.water = 0;
		villageData.wood = 0;
		villageData.stone = 0;
		villageData.cur_population = 2;
		villageData.max_population = 5;

		Save ();
	}
	
//	void OnGUI(){
//		GUI.Label (new Rect(200, 10, 150, 30), "Mission: ");
//		GUI.Label (new Rect(200, 30, 150, 30), "started: " + openWorldData.mission1.started);
//		GUI.Label (new Rect(200, 50, 150, 30), "finished: " + openWorldData.mission1.finished);
//		GUI.Label (new Rect(200, 10, 150, 30), "Level: " + playerData.level);
//		GUI.Label (new Rect(200, 30, 150, 30), "Health: " + playerData.curHealth);
//		GUI.Label (new Rect(200, 50, 150, 30), "Energy: " + playerData.curEnergy);
//		GUI.Label (new Rect(200, 70, 150, 30), "Experience: " + playerData.curExperience);
//		GUI.Label (new Rect(200, 90, 150, 30), "DamageMultiplier: " + playerData.curDamageMultiplier);
//
//		GUI.Label (new Rect(200, 110, 150, 30), "playerPosX: " + openWorldData.playerPosX);
//		GUI.Label (new Rect(200, 130, 150, 30), "playerPosY: " + openWorldData.playerPosY);
//		GUI.Label (new Rect(200, 150, 150, 30), "PlayerPosZ: " + openWorldData.playerPosZ);
//		GUI.Label (new Rect(200, 170, 150, 30), "EnemyIsDead: " + openWorldData.enemy1.isDead);
//		GUI.Label (new Rect(200, 190, 150, 30), "EnemyPosX: " + openWorldData.enemy1.posX);
//		GUI.Label (new Rect(200, 210, 150, 30), "EnemyPosY: " + openWorldData.enemy1.posY);
//		GUI.Label (new Rect(200, 230, 150, 30), "EnemyPosZ: " + openWorldData.enemy1.posZ);
//
//		GUI.Label (new Rect (200, 250, 150, 30), "Turn: " + villageData.turn);
//		GUI.Label (new Rect(200, 270, 150, 30), "EnemyisPlayerInSight: " + openWorldData.enemy1.isPlayerInSight);
//	}
}
//DATA1
[Serializable]
public class PlayerData{
	public int level;
	public int curHealth;
	public int curEnergy;
	public int curExperience;
	public int curDamageMultiplier;
}
//DATA2
[Serializable]
public class OpenWorldData{
	public int turn;

	public float playerPosX;
	public float playerPosY;
	public float playerPosZ;
	public int enemyType;
	public EnemyData enemy1 = new EnemyData();
	public MissionData mission1 = new MissionData ();
	public NeutralData neutral1 = new NeutralData ();
}
//TODO
//[Serializable]
//public class NPCData{
//	public EnemyData enemy1 = new EnemyData();
//}
[Serializable]
public class EnemyData{
	public int isDead;
	public bool isPlayerInSight;
	public float posX;
	public float posY;
	public float posZ;
}
[Serializable]
public class MissionData{
	public bool started;
	public bool finished;
}
[Serializable]
public class NeutralData{
	public int isDead;
	public bool isEnemy;
	public float posX;
	public float posY;
	public float posZ;
}
//DATA3
[Serializable]
public class VillageData{
	//five buildings' levels
	public int lvl_building1;
	public int lvl_building2;
	public int lvl_building3;
	public int lvl_building4;
	public int lvl_building5;

	//resources
	public int gold;
	public int food;
	public int water;
	public int wood;
	public int stone;
	public int cur_population;
	public int max_population;
}
//public class BuildingData{
//	public int turn;
//	
//}