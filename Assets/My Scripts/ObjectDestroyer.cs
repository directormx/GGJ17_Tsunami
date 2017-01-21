using UnityEngine;
using System.Collections;

public class ObjectDestroyer : MonoBehaviour {

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void OnCollisionEnter2D(Collision2D obj) {
		Destroy (obj.gameObject);
	}

	public void OnTriggerEnter2D(Collider2D node) {
		Destroy(node.gameObject);
	}

}
