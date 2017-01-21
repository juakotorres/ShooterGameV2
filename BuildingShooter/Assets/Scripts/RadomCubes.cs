﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomCubes : MonoBehaviour {

	public GameObject Cubeprefab;

	public Vector3 center;
	public Vector3 size;
	public float spawns;

	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < spawns; i++) {
			Spawn ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKey (KeyCode.Q)) {
			Spawn ();
		}*/
	}

	public void Spawn(){
		center = transform.localPosition;
		Vector3 pos = center + new Vector3 (Random.Range (-size.x / 2, size.x / 2), Random.Range (-size.y / 2, size.y / 2), Random.Range (-size.z / 2, size.z / 2));
		
		Instantiate (Cubeprefab, pos, Quaternion.identity);
	}

	void OnDrawGizmosSelected(){

		Gizmos.color = new Color (1,0,0,0.5f);
		Gizmos.DrawCube (center, size);

	}
}
