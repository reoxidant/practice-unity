using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureNadi : MonoBehaviour {

	[SerializeField] Text textComponent;
	[SerializeField] State startingState;

//	string[] daysOfTheWeek = { "Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

	State state;

	// Use this for initialization
	void Start () {
		state = startingState;
		textComponent.text = state.GetStateStory ();
	}
	
	// Update is called once per frame
	void Update () {
		ManageState ();
	}

	private void ManageState()
	{
		var anotherStates = state.GetAnotherStates();

		for (int i = 0; i < anotherStates.Length; i++)
		{
			if (Input.GetKeyDown (KeyCode.Alpha1 + i)) 
			{
				state = anotherStates [i];
			}
		}

		textComponent.text = state.GetStateStory ();
	}
}
