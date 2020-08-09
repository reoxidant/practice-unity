using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_6 : MonoBehaviour {

	public GameObject obj;
	private GameObject inst_obj;
	[SerializeField]
	private float speed = 4f;

	// Use this for initialization
	void Start () {
		inst_obj = Instantiate (obj, new Vector3(0,0,0), Quaternion.identity) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		float zPos = Input.GetAxis ("Vertical");

		inst_obj.transform.Translate (Vector3.forward * speed * zPos * Time.deltaTime);
	}
}
