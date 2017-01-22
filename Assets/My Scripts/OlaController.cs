using UnityEngine;
using System.Collections;

public class OlaController : MonoBehaviour {

	public GameObject canvas;
	public GameObject playerDead;

	public void OnCollisionEnter2D(Collision2D obj) {
		if (obj.gameObject.name == "Player") {
			MostrarGameOver ();
			Destroy (obj.gameObject);

		}

	}

	public void OnTriggerEnter2D(Collider2D node) {
		if (node.gameObject.name == "Player") {
			MostrarGameOver ();
			Destroy(node.gameObject);
		}
	}

	void SpawnPlayerDead()
	{
		GameObject newGameObject = Instantiate(playerDead);
		newGameObject.transform.position =new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
	}

	public void MostrarGameOver()
	{
		canvas.SetActive (true);
		SpawnPlayerDead ();
		//StopTime ();
	}

	void StopTime()
	{
		Time.timeScale = 0.00001f;
	}
}
