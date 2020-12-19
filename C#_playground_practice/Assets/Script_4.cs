using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_4 : MonoBehaviour {

	public GameObject[] objects;
	private GameObject inst_obj;

	// Use this for initialization
	void Start () {
		int rand = Random.Range(0, objects.Length - 1);
		inst_obj = Instantiate (objects [rand], objects [rand].transform.position, Quaternion.identity) as GameObject;
		inst_obj.transform.localScale = new Vector3 (0.25f, 0.25f, 0.25f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
