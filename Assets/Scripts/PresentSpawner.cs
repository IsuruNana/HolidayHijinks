using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Makes the presents

public class PresentSpawner : MonoBehaviour {

	public GameObject present;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 5f;
	float nextSpawn = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > nextSpawn) {
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range (-8.5f, 8.5f);
			whereToSpawn = new Vector2 (randX, transform.position.y);
			Instantiate (present, whereToSpawn, Quaternion.identity);
			present.gameObject.SetActive (true);
		}
		
	}
}
