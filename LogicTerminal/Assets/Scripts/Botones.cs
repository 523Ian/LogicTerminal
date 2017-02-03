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



	public void Reset(int NumeroEscena)
	{
//        int nivelActual = Persistente.instancia.NivelActual;
//
//        string nombreNivel = "Level_" + nivelActual;
//
//        SceneManager.UnloadScene(nombreNivel);
//        SceneManager.LoadScene(nombreNivel, LoadSceneMode.Additive);
//
		SceneManager.LoadScene ("Level_" + NumeroEscena);
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
