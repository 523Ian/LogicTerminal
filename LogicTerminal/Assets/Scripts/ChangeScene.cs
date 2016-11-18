using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour 
{
	public Scene Escena;

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player")
			SceneManager.LoadScene ("Level2");
	}
}
