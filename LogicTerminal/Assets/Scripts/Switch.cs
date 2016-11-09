using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour 
{
	public bool IsOpen = false;
	public float DistVertical = 2.5f;
	public float DistHorizontal = 2.5f; 
		


	public void SwitchDoor()
	{
		if(IsOpen)
		{
			transform.position = new Vector3 (transform.position.x-DistHorizontal,transform.position.y-DistVertical);
			IsOpen  = false;
		} else
		{
			transform.position = new Vector3 (transform.position.x+DistHorizontal,transform.position.y+DistVertical);
			IsOpen = true;
		}
	}
}
