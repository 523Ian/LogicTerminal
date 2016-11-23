using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trampa : MonoBehaviour {


	int nivelActual = Persistente.instancia.NivelActual;

	public GameObject ObjetoTrampa;


	void Start () 
	{
	}

	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") {
			StartCoroutine (Reiniciar ());
		}
	}
	IEnumerator Reiniciar()
	{
		string nombreNivel = "Level_" + nivelActual;
		ObjetoTrampa.SetActive (true);

		yield return new WaitForSeconds (3f);

		SceneManager.UnloadScene(nombreNivel);
		SceneManager.LoadScene(nombreNivel, LoadSceneMode.Additive);
	}
}
