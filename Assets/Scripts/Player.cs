using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int accelForce;
	public float turnSpeedDegrees;
	public GameObject bullet;

	private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = (Rigidbody2D) GetComponent(typeof(Rigidbody2D));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
			rigidBody.AddForce(transform.up);
		}
		if (Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow)) {
			rigidBody.AddForce(-transform.up);
		}
		rigidBody.angularVelocity = 0f;
		if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow)) {
			rigidBody.MoveRotation(rigidBody.rotation + turnSpeedDegrees * Time.fixedDeltaTime);
		}
		if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)) {
			rigidBody.MoveRotation(rigidBody.rotation - turnSpeedDegrees * Time.fixedDeltaTime);
		}

		if (Input.GetKeyUp(KeyCode.Space)) {
			Instantiate(bullet, transform.position + (transform.forward * 10), transform.rotation);
		}
	}
}
