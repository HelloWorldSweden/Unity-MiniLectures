using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFloor : MonoBehaviour {

    private Vector3 restartPosition;
    private Vector3 restartRot;

	// Use this for initialization
	void Start () {
        Transform playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        restartPosition = playerTrans.position;
        restartRot = playerTrans.localEulerAngles;
    }
	
	void OnTriggerEnter(Collider coll) {
        if (coll.tag == "Player") {
            coll.transform.position = restartPosition;
            coll.transform.localEulerAngles = restartRot;
        }
    }
}
