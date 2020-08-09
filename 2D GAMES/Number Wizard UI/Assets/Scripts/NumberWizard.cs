using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

	[SerializeField] int max;
	[SerializeField] int min;
	[SerializeField] TextMeshProUGUI guessText;

	int guess;

	// Use this for initialization
	void Start () {
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 20;
		StartGame ();
	}

	void StartGame()
	{
		NextGuess ();
	}

	public void OnPressHigher()
	{
		//need to use +1 becouse if you have guess = 500, next level shall be 501, 
		//becouse range include variable 500
		//and you can see 500 on the screen again

		min = guess + 1;
		NextGuess ();
	}

	public void OnPressLower()
	{
		max = guess - 1;
		NextGuess ();
	}

	void NextGuess()
	{
		//need to install var max + 1 becouse you never get 1000, from 999 - 1000 always says 999
		guess = Random.Range(min, max + 1);
		guessText.text = guess.ToString ();
	}
}