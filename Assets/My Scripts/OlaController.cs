using UnityEngine;
using System.Collections;

public class OlaController : MonoBehaviour {

	public GameObject canvas;

	public void OnCollisionEnter2D(Collision2D obj) {
		if (obj.gameObject.name == "Player") {
			Destroy (obj.gameObject);
			MostrarGameOver ();
		}

	}

	public void OnTriggerEnter2D(Collider2D node) {
		if (node.gameObject.name == "Player") {
			Destroy(node.gameObject);
			MostrarGameOver ();
	}
}
	public void MostrarGameOver()
	{
		canvas.SetActive (true);
		StopTime ();
	}

	void StopTime()
	{
		Time.timeScale = 0.00001f;
	}
}
