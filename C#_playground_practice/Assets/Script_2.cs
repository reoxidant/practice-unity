using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_2 : MonoBehaviour {

	public GameObject obj;
	private Light mylight;

	private int numEnemis = 11;

	// Use this for initialization
	void Start () {
		mylight = GetComponent <Light> ();

		for (int i = 0; i < numEnemis; i++)
			Debug.Log ("Create " + i + " enemies!");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			mylight.enabled = !mylight.enabled;
		}

		if (Input.GetKeyUp (KeyCode.A)) {
			obj.SetActive (false);
		}

		if (Input.GetKeyUp (KeyCode.S)) { 
			Destroy (obj);
		}

		if (Input.GetKeyUp (KeyCode.R))
			obj.GetComponent <Renderer> ().material.color = Color.red;
		else if (Input.GetKeyUp (KeyCode.G))
			obj.GetComponent <Renderer> ().material.color = Color.green;
		else if (Input.GetKeyUp (KeyCode.B))
			obj.GetComponent <Renderer> ().material.color = Color.blue;

//		switch (obj) {}
	
	}
}
