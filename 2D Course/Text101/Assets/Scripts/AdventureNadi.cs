using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdventureNadi : MonoBehaviour 
{
	[SerializeField] Text textComponent;
	[SerializeField] State startingState;

	State state;

	// Use this for initialization
	void Start () 
	{
		state = startingState;
		textComponent.text = state.GetStateStory();
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

		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			Debug.Log ("Quit!");
			QuitGame ();
		}
			
		textComponent.text = state.GetStateStory ();
	}

	private void QuitGame()
	{
		SceneManager.LoadScene("TextStory");	
	}
}