using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {

	public float speed;

	private Rigidbody cap;

	// Use this for initialization
	void Start () {
		cap = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (0.0f, moveVertical, 0.0f);

		cap.AddForce (movement * speed);
	}

}
