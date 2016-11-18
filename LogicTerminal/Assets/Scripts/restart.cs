using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour 
{
	public string Escena;
	void Update () 
	{
		if(Input.GetKey(KeyCode.R)){
			SceneManager.LoadScene(Escena);
		}
	}
}
