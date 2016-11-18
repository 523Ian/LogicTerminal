using UnityEngine;
using System.Collections;

public class RotPlat : MonoBehaviour 
{
	public float Vel;
	
	void Update () 
	{
		transform.Rotate (0, Vel, 0);
	}
}
