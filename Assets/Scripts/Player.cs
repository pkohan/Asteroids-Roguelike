using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int accelForce = 1;
	public Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = (Rigidbody2D) GetComponent(typeof(Rigidbody2D));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) {
			rigidBody.AddForce(new Vector2(0, accelForce));
		}
		if (Input.GetKey(KeyCode.S)) {
			rigidBody.AddForce(new Vector2(0, -accelForce));
		}
		if (Input.GetKey(KeyCode.A)) {
			rigidBody.AddForce(new Vector2(-accelForce, 0));
		}
		if (Input.GetKey(KeyCode.D)) {
			rigidBody.AddForce(new Vector2(accelForce, 0));
		}
	}
}
