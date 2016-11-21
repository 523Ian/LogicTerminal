using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Laser : MonoBehaviour 
{
	LineRenderer _line;
	public Transform A;
	public Transform B;

	void Start()
	{
		_line = GetComponent<LineRenderer> ();
	}



	void Update()
	{
		_line.SetColors (Color.red, Color.red);
		_line.SetPosition (0, A.position);
		_line.SetPosition (1, B.position);
	}
}
