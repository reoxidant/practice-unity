using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour 
{
	public void LoadNextScene()
	{
		int currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (currentSceneIndex + 1);
	}

	public void LoadStartMenu()
	{
		SceneManager.LoadScene (0);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
