﻿using UnityEngine;
using System.Collections;

public class DebugSpawn : MonoBehaviour {
	public GameObject prefab;
	// Use this for initialization
	void Start () {
		Instantiate(prefab, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
