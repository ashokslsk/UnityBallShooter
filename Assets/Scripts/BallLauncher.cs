using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

	public float Speed;
	public GameObject ballPrefab;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Speed = 10.0f;

		if (Input.GetButtonDown ("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.forward * Speed;
		}
	}
}
