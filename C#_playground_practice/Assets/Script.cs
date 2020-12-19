using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour {

	[SerializeField]
	private float i = 28.12f; 

	void FixedUpdate(){
		Debug.Log ("FixedUpdate time :" + Time.deltaTime);
	}
		
	// Use this for initialization
	void Start () {
		Show ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update time: " + Time.deltaTime);
	}

	void Show(){
		print (i);
	}
}
