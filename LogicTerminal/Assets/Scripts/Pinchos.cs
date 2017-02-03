using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pinchos : MonoBehaviour 
{
	public int nivelActual;

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") {
			SceneManager.LoadScene ("Level_" + nivelActual);
		}
	}
}
