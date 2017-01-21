using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour {

	public GameObject objetoASpawnear;
	public float frecuenciaDeSpawneo;
	public float coordenadaX;
	public float coordenadaY;
	public float coordenadaZ;
	void Start () {

		InvokeRepeating ("SpawnObject", frecuenciaDeSpawneo, frecuenciaDeSpawneo);
	}


	void SpawnObject()
	{
		Vector3 position = new Vector3(coordenadaX, coordenadaY, coordenadaZ);
		GameObject newGameObject = Instantiate(objetoASpawnear);
		newGameObject.transform.position = position;
	}
}
