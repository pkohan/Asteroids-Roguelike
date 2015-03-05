using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public Transform player;
	private Renderer rend;

	void Start() {
		rend = (Renderer) GetComponent(typeof(Renderer));
	}

	// Update is called once per frame
	void Update () {
		rend.material.mainTextureOffset = new Vector2(player.position.x, player.position.y);
	}
}
