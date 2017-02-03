using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour 
{
	public int SiguienteNivel;

	void OnTriggerEnter2D(Collider2D c)
	{
		SceneManager.LoadScene ("Level_" + SiguienteNivel);
	}
}
