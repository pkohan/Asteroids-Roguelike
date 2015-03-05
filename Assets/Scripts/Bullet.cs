using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public int speed;
	public float maxTimeAlive;

	private Rigidbody2D rb;
	private float spawnTime;

	// Use this for initialization
	void Start () {
		rb = (Rigidbody2D) GetComponent(typeof(Rigidbody2D));
		rb.velocity = transform.up * speed;
		spawnTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - spawnTime > maxTimeAlive) {
			Destroy(gameObject);
		}
	}
}
