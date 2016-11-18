using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour 
{
	public string NameScene;
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player") {
			SceneManager.LoadScene (NameScene);
		}
	}
}
