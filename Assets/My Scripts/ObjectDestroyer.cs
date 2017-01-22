using UnityEngine;
using System.Collections;

public class ObjectDestroyer : MonoBehaviour {

	public GameObject canvas;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void OnCollisionEnter2D(Collision2D obj) {
		Destroy (obj.gameObject);
		if (obj.gameObject.name == "Player") {
			MostrarGameOver ();
		}
	}

	public void OnTriggerEnter2D(Collider2D node) {
		Destroy(node.gameObject);
		if (node.gameObject.name == "Player") {
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
