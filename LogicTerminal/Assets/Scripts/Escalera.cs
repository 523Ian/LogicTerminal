using UnityEngine;
using System.Collections;

public class Escalera : MonoBehaviour 
{


	void OnTriggerEnter2D(Collider2D otro)
	{
		if(otro.tag == "Player"){
			mover m = otro.GetComponent<mover>();
			m.CanEnter = true;
		}
	}
	void OnTriggerExit2D(Collider2D otro)
	{
		if(otro.tag == "Player"){
			mover m = otro.GetComponent<mover>();
			m.CanEnter = false;
			m.SalirEscalera ();
		}
	}
}
