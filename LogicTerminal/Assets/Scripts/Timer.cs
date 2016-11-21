using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Timer : MonoBehaviour {

	public Text TimeText;
	public float T = 60f;
	public string Scene;

	void Start()
	{
	}



	void Update () 
	{
		T -= Time.deltaTime;
		TimeText.text =  "" + T.ToString ("f1");
		if (T < 0) {
			T = 100f;
			SceneManager.LoadScene (Scene);
		}
	}
}
