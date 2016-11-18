using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pinchos : MonoBehaviour 
{
	public string Escena;
	void Start () 
	{
	
	}
	
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player")
		SceneManager.LoadScene (Escena);
	}
}
