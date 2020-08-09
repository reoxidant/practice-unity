using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_5 : MonoBehaviour {

	public GameObject obj;

	IEnumerator instObj () {
		int i = 0;
		while (i < 10) {
			i++;
			Instantiate (obj, new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f)), Quaternion.identity);
			yield return new WaitForSeconds (1.5f);
		}
	}

	// Use this for initialization
	void Start () {
		Invoke ("Inst", 2f);	
	}

	void Inst(){
		Instantiate (obj, new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f)), Quaternion.identity);
	}	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.F))
			StartCoroutine (instObj ());
	}
}
