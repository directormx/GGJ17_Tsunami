using UnityEngine;
using System.Collections;

public class IntroController : MonoBehaviour {


	void Start()
	{
		Time.timeScale = 1;
	}
	public void IrALevel1()
	{
		Application.LoadLevel("Level1");
	}

}
