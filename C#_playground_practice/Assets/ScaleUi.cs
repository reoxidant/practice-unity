using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleUi : MonoBehaviour {

	private Text txt;
	private int count;

	void Start(){
		txt = GameObject.Find ("Text").GetComponent <Text> ();
	}

	void OnMouseDown ()
	{
		transform.localScale = new Vector3 (transform.localScale.x / 2, transform.localScale.y / 2, transform.localScale.z / 2);		
	}

	void OnTriggerEnter(Collider other){
		count++;
		txt.text = other.gameObject.name + " " + count.ToString ();
	}
}
