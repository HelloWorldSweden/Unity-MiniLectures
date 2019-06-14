using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public string nextLevelName;
    public Transform visuals;
    private float rotationSpeed = 720;

    void Update() {
        visuals.localEulerAngles += new Vector3(rotationSpeed/2, rotationSpeed, rotationSpeed/3) * Time.deltaTime;
    }

    void OnTriggerEnter(Collider coll) {
        if(coll.tag == "Player")
            SceneManager.LoadScene(nextLevelName);
    }
	
}
