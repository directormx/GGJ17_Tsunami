using UnityEngine;
using System.Collections;

public class TransportarObjetos : MonoBehaviour {

	public GameObject prefab;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		MoverObjeto ();
	}
		

	void MoverObjeto()
	{
		prefab.transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime);
	}
}
