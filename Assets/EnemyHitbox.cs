﻿using UnityEngine;
using System.Collections;

public class EnemyHitbox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider obj_disentuh){
		
		if (obj_disentuh.name=="Hero") {
			Application.LoadLevel("GameOver");
		}
		
		
	}
}
