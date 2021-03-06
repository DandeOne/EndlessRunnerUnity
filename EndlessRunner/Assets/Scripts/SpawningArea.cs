﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Spawns a prefab randomly throughout the volume of a Unity transform. Attach to a Unity cube to visually scale or rotate. For best results disable collider and renderer.
/// </summary>
public class SpawningArea : MonoBehaviour
{

    public GameObject ObjectToSpawn;
    public float RateOfSpawn = 1;
    public int howManyCoins;
    private float nextSpawn = 0;
    public bool isSpawningCoins;
    // Update is called once per frame
    
    void Update()
    {
        if (howManyCoins > 0)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + RateOfSpawn;

                // Random position within this transform
                Vector3 rndPosWithin;
                rndPosWithin = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
                rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
                var go = Instantiate(ObjectToSpawn, rndPosWithin, transform.rotation) as GameObject;
                if(isSpawningCoins)
                go.transform.SetParent(gameObject.transform);
                howManyCoins--;
            }
        }
    }
}