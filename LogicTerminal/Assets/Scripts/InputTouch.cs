using UnityEngine;
using System.Collections;

public class InputTouch : MonoBehaviour 
{

	void Update () 
	{
		if(Input.touchCount > 0) {
			Debug.Log(Input.touches[0].position);
		}
	}
}