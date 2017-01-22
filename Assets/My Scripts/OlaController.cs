using UnityEngine;
using System.Collections;

public class OlaController : MonoBehaviour {


	public void OnCollisionEnter2D(Collision2D obj) {
		if (obj.gameObject.name == "Player") {
			Destroy (obj.gameObject);
		}

	}

	public void OnTriggerEnter2D(Collider2D node) {
		if (node.gameObject.name == "Player") {
			Destroy(node.gameObject);
	}
}
}
