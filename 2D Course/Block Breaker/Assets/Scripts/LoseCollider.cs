using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision) 
		{
			SceneManager.LoadScene ("Game Over");
		}
	}
}
