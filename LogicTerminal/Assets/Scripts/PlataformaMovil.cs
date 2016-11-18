using UnityEngine;
using System.Collections;

public class PlataformaMovil : MonoBehaviour 
{
	public float Vel = 50;
	public float t = 5;

	void Start () {
		StartCoroutine (Trasladar ());
	}
		
	IEnumerator Trasladar ()
	{
		while (true) {	
			transform.Translate (Vel * Time.deltaTime, 0, 0);
			yield return new WaitForSeconds (t);
			transform.Translate (-Vel * Time.deltaTime, 0, 0);
			yield return new WaitForSeconds (t);
		}
	}
}
