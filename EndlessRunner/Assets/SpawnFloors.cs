﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloors : MonoBehaviour {

    public GameObject firstFloor;
    public GameObject positionToSpawn;
    public float TimeInterval;
    float nextSpawnTime;
    bool isFloorCreated;
	// Use this for initialization
	void Start () {
        nextSpawnTime = Time.time + TimeInterval;
        isFloorCreated = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isFloorCreated)
        {
            if (Time.time > nextSpawnTime)
            {
                GameObject go = Instantiate(firstFloor, new Vector3(positionToSpawn.transform.position.x, positionToSpawn.transform.position.y, positionToSpawn.transform.position.z), new Quaternion(0, 0, 0, 0)) as GameObject;
                
                isFloorCreated = true;
                nextSpawnTime += TimeInterval;
            }
        }
	}
}