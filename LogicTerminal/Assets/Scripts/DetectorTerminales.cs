using UnityEngine;
using System.Collections;

public class DetectorTerminales : MonoBehaviour 
{
    public Terminal TerminalActual;

	void Start () 
    {
	
	}
	
	void Update () 
    {
	
	}


    public void UsarTerminal()
    {
        if(TerminalActual != null) {
            TerminalActual.SwitchPuerta();
        }
    }
}
