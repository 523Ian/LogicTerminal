using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DetectorTerminales : MonoBehaviour 
{
    public List<Terminal> Terminales;

	void Start () 
    {
        Terminales = new List<Terminal>();
	}
	
	void Update () 
    {
	
	}


    public void AnhadirTerminal(Terminal t)
    {
        if(Terminales.IndexOf(t) == -1){
            Terminales.Add(t);
        }
    }



    public void QuitarTerminal(Terminal t)
    {
        Terminales.Remove(t);
    }


    public void UsarTerminales()
    {
        for(int i=0;i<Terminales.Count;i++)
        {
            Terminales[i].UsarSwitch();
        }
    }
}
