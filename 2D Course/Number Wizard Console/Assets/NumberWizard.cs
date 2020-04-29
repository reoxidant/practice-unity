using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame ();
		max = max + 1;//1001
	}

	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;

		Debug.Log ("Добро пожаловать в игру - Волшебное число");
		Debug.Log ("Загадайте число...");
		Debug.Log ("Загадайте число не ниже: " + max);
		Debug.Log ("Загадайте число не выше: " + min);
		Debug.Log ("Нажимайте на клавиши, Вверх, Вниз и Ввод");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();//750
		} 
	
		else if(Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			NextGuess ();//
		}

		else if(Input.GetKeyDown(KeyCode.Return)){
			Debug.Log("Я гений!");
			StartGame ();
		}
	}
	void NextGuess()
	{
		Debug.Log("max: " + max + " min: " + min + " guess: " + guess);

		guess = (max + min) / 2;
		Debug.Log ("Это число больше или меньше..." + guess);
	}
}
