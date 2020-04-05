using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour {
	Rigidbody2D rigidbody2d;

	// Start is called before the first frame update
	void Start() {
		// Forces game to run at 10 Frames Per Second.
		// QualitySettings.vSyncCount = 0;
		// Application.targetFrameRate = 10;
		rigidbody2d = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update() {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		/*
		 * If the game runs at ten frames per second, each frame will take 0.1 seconds (1/10).
		 * Otherwise if it runs at 60 frames per second, each frame will take 0.017 seconds (1/60).
		 * 
		 * Debug.Log(Time.deltaTime);
		 */
		float deltaTime = Time.deltaTime;

		Vector2 position = rigidbody2d.position;
		position.x = position.x + 8.0f * horizontal * deltaTime;
		position.y = position.y + 8.0f * vertical * deltaTime;

		rigidbody2d.MovePosition(position); // Fix Ruby's Jittering
	}
}
