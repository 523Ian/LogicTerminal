using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour 
{

	public void SceneSelector(string Escena)
	{
		SceneManager.LoadScene (Escena);	
	}



	public void Exit()
	{
		Application.Quit ();
	}



	public void Reset(string Escena)
	{
		SceneManager.LoadScene (Escena);
	}


	public void Open(GameObject Obj)
	{
		Obj.SetActive (true);
	}

	public void Close(GameObject Obj)
	{
		Obj.SetActive (false);
	}
}
