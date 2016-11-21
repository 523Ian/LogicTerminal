using UnityEngine;
using System.Collections;

public class Rotar : MonoBehaviour 
{

	public float Velo = 50;

	void Start () 
	{
	}



	void Update () 
	{
		transform.Rotate (0, Velo * Time.deltaTime, 0);
	}
}