using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facit1 : MonoBehaviour {

    public GameObject objectToSpawn;
    public Vector3 spawnPoint;

    private int spawnCounter = 0;
    private float spawnDistance = 1;
	

	void Update () {
	    if(Input.GetKeyDown(KeyCode.P)) {
            Vector3 newSpawnPos = spawnPoint;
            newSpawnPos.x += spawnCounter * spawnDistance;
            Instantiate(objectToSpawn, newSpawnPos, Quaternion.identity);
            spawnCounter += 1;
        }
	}
    
}
