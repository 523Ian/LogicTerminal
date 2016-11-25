using UnityEngine;
using System.Collections;

public class Terminal : MonoBehaviour 
{
	SpriteRenderer _rend;
    bool _estaActivo;

    public Switch Switch;
	public Sprite SpriteActivo;
	public Sprite SpriteInactivo;


	void Start () 
	{
		_rend = GetComponent<SpriteRenderer> ();
        _estaActivo = false;
	}
	
	void Update () 
	{
	} 	 

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") {
            c.GetComponent<DetectorTerminales>().AnhadirTerminal(this);
		}
	}
	void OnTriggerExit2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") {
            c.GetComponent<DetectorTerminales>().QuitarTerminal(this);
		}
	}



	public void UsarSwitch()
	{
        _estaActivo = ! _estaActivo;

        _rend.sprite = _estaActivo ? SpriteActivo : SpriteInactivo;

        Switch.HacerSwitch(_estaActivo);
	}


    public void MostrarActivo(bool estaActivo)
    {
        _estaActivo = estaActivo;
        _rend.sprite = _estaActivo ? SpriteActivo : SpriteInactivo;
    }
}
