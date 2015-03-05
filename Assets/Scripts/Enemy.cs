using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float turnSpeedDegrees;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = (Rigidbody2D) GetComponent(typeof(Rigidbody2D));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.MoveRotation(rb.rotation - turnSpeedDegrees * Time.fixedDeltaTime);
	}
}
