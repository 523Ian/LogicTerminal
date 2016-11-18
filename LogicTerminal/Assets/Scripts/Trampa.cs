using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trampa : MonoBehaviour {

	public GameObject Trap;
	public string Escena;

	void Start () 
	{
		StartCoroutine (Desactivar ());
	}

	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") {
			Trap.SetActive (true);
			StartCoroutine (Reiniciar ());

		}
	}

	IEnumerator Desactivar()
	{
		yield return new WaitForSeconds (0.3f);
		Trap.SetActive (false);
	}
	IEnumerator Reiniciar()
	{
		yield return new WaitForSeconds (3);
		SceneManager.LoadScene (Escena);
	}
}
