using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3(player.position.x, player.position.y, -2);
	}
}
