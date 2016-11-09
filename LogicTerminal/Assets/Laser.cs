using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Laser : MonoBehaviour {

	public string Escena;
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player")
			SceneManager.LoadScene (Escena);
	}
}
