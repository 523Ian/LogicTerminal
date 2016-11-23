using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pinchos : MonoBehaviour 
{
	int nivelActual = Persistente.instancia.NivelActual;


	void Start () 
	{
	
	}
	
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") {
			string nombreNivel = "Level_" + nivelActual;
			SceneManager.UnloadScene (nombreNivel);
			SceneManager.LoadScene (nombreNivel, LoadSceneMode.Additive);
		}
	}
}
