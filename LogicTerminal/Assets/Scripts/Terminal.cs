using UnityEngine;
using System.Collections;

public class Terminal : MonoBehaviour 
{
	SpriteRenderer _rend;

	public GameObject puerta;
	bool isInside = false;
	public Switch Switch;
	public GameObject ActionButton;
	public GameObject Trap;
	public GameObject Laser;

	public Sprite Activo;
	public Sprite Inactivo;

	public bool HayTrampa;
	public bool HayLaser;
	public bool LaserActivo;


	void Start () 
	{
		_rend = GetComponent<SpriteRenderer> ();

		ActionButton = GameObject.FindGameObjectWithTag ("BotonUsar");
		LaserActivo = true;
	}
	
	void Update () 
	{
        if (Switch.IsOpen) {
			_rend.sprite = Activo;
		} else {
			_rend.sprite = Inactivo;
		}

	} 	 

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") {
			isInside = true;
			ActionButton.SetActive (true);
			ActionButton.GetComponent<ActionButton> ().TerminalActual = this;

		}
	}
	void OnTriggerExit2D(Collider2D c)
	{
		if (c.gameObject.tag == "Player") {
			isInside = false;
			ActionButton.SetActive (false);
			ActionButton.GetComponent<ActionButton> ().TerminalActual = null;;
		}
	}

	public void SwitchPuerta()
	{
		if (isInside) {
			Switch.SwitchDoor ();

			if (HayTrampa) {
				Destroy (Trap);
			}
			if (HayLaser) {
				if (LaserActivo) {
					Laser.SetActive (false);
					LaserActivo = false;
				} else {
					Laser.SetActive (true);
					LaserActivo = true;
				}
			}
		}
	}
}
