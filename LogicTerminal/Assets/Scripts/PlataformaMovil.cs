using UnityEngine;
using System.Collections;

public class PlataformaMovil : MonoBehaviour 
{
	public Transform A;
	public Transform B;
	public float Suavidad = 3f;
	public float Tiempo = 3f;
//	public Vector3 NewPos;

	void Start () 
	{
		transform.position = A.position;
		//StartCoroutine (Plataformas ());
	}
	
	void Update () 
	{
		//transform.position = Vector2.Lerp (A.position, B.position, Suavidad * Time.deltaTime);
		transform.position = Vector2.Lerp (B.position, A.position, Suavidad * Time.deltaTime);

	}

	IEnumerator Plataformas()
	{
		
		yield return new WaitForSeconds (Tiempo);

		yield return new WaitForSeconds (Tiempo);
	}
}
