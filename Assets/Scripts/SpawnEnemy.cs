using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public GameObject enemy;
	public GameObject player;
	public float minDistance;
	public float maxDistance;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Z)) {
			Instantiate(enemy, getRandomPosition(), Quaternion.identity);
		}
	}

	private Vector3 getRandomPosition() {
		float xRandom = Random.Range(-maxDistance, maxDistance);
		float yRandom = Random.Range(-maxDistance, maxDistance);
		return new Vector3(player.transform.position.x + xRandom, player.transform.position.y + yRandom, 0);
	}
}