using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Config parameters
	[SerializeField] Paddle paddle1;

	// States
	Vector2 paddleToBallVector;

	// Use this for initialization
	void Start () 
	{
		paddleToBallVector = transform.position - paddle1.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 paddlePos = new Vector2 (paddle1.transform.position.x, paddle1.transform.position.y);
		transform.position = paddlePos + paddleToBallVector;
	}
}
