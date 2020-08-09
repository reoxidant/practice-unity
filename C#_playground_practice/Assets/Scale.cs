using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {

	void OnMouseDown ()
	{
		transform.localScale = new Vector3 (transform.localScale.x / 2, transform.localScale.y / 2, transform.localScale.z / 2);		
	}

	void OnTriggerEnter(Collider other){
		print (other.gameObject.name);
	}
}
