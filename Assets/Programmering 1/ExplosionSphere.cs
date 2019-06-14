using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for(int i = 0; i < 20; i++) {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            cube.transform.position = transform.position;

            cube.GetComponent<Collider>().enabled = false;
            Rigidbody rigid = cube.AddComponent<Rigidbody>();
            rigid.AddForce(getRandomForce());
            cube.GetComponent<MeshRenderer>().material.color = getRandomColor();
        }
	}
	

    private Vector3 getRandomForce() {
        return new Vector3(getRandFloat(), getRandFloat(), getRandFloat());
    }
    private float getRandFloat() {
        return Random.RandomRange(-10, 10) * 100;
    }

    private Color getRandomColor() {
        return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

}
