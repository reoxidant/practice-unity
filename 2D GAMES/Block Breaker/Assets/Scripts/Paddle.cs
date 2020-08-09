using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	[SerializeField] float minXpos = 1f;
	[SerializeField] float maxXpos = 15f;
	[SerializeField] float screenWidthInUnits = 16f;
	private float mousePositionInUnits;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		mousePositionInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
		Vector2 paddlePosition = new Vector2 (transform.position.x, transform.position.y);
		paddlePosition.x = Mathf.Clamp (mousePositionInUnits, minXpos, maxXpos);
		transform.position = paddlePosition;
	}
}
