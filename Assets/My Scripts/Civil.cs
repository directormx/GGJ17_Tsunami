using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Civil : MonoBehaviour {

    public AudioClip sonido;


	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = sonido;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    /*void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log ("a");
		if (col.gameObject.tag == "Player") {
			Debug.Log ("Hola");
            sonido = GetComponent<AudioSource> ();
            sonido.Play ();
		}
	}*/

    void OnCollisionEnter()  //Plays Sound Whenever collision detected
    {
        GetComponent<AudioSource>().Play();
    }
}
