using UnityEngine;
using System.Collections;

public class ActionButton : MonoBehaviour 
{
	public void UsarTerminal()
	{
        DetectorTerminales detector = GameObject.FindGameObjectWithTag("Player").GetComponent<DetectorTerminales>();
        detector.UsarTerminal();
	}
}
