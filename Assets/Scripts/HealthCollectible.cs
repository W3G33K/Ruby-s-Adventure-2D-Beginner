using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("GameObject that entered the trigger: " + other);

		RubyController controller = other.GetComponent<RubyController>();
		if (controller != null) {
			if (controller.GetCurrentHealth() < controller.maxHealth) {
				controller.ChangeHealth(1);
				Destroy(gameObject);
			}
		}
	}
}
