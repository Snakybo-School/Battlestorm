﻿using UnityEngine;
using System.Collections;

public class SpawnBuilding : MonoBehaviour {
	public enum BuildingType{
		Tower = 1,
		WoodWorks = 2,
		Mine = 3
	};
	public GameObject buildingobj;
	private Transform buildingPos;
	private BuildingType building;
	void Start () {
		buildingPos = transform.FindChild("BuildingPosition");
		//Instantiate(Resources.Load("Prefabs/Test/LumberMill"),buildingPos.position,Quaternion.identity);
	}
	public void createBuilding(int type){
		Debug.Log(type);
		if(type == 1){
			buildingobj = Instantiate(Resources.Load("Prefabs/Test/LumberMill"),buildingPos.position,Quaternion.identity) as GameObject;
			buildingobj.transform.parent = this.transform;
		}
		if(type == 2){
			buildingobj = Instantiate(Resources.Load("Prefabs/Test/Mine"),buildingPos.position,Quaternion.identity) as GameObject;
			buildingobj.transform.parent = this.transform;
		}
		if(type == 3){
			//Spawn Tower
		}
	}

}