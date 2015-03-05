using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public int speed;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = (Rigidbody2D) GetComponent(typeof(Rigidbody2D));
		rb.velocity = transform.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
