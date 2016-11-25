﻿using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour 
{
	Rigidbody2D _rb;
    GameController _gc;

	bool _canJump;
	bool _walking;
	bool _ladder;
	int _dirx;
	int _diry;
	public bool HasCard;

	public bool CanEnter;
	public float Velocidad = 6;
	public float JumpForce = 300;



	void Start () 
	{
        
		_rb  = GetComponent<Rigidbody2D>();
        _gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

		_canJump = true;
		_walking = true;
		CanEnter = false;
		_ladder = false;
		HasCard = false;

		_dirx = 0;
		_diry = 0;

        transform.position = _gc.PuntoInicio.position;
	}



	void Update () 
	{
		float velx = _dirx * Velocidad * Time.deltaTime;
		float vely = _diry * Velocidad * Time.deltaTime;
		_walking = velx != 0;

		if(_walking){
			transform.Translate (velx, 0, 0);

			_rb.gravityScale = 1;
			_rb.isKinematic = false;
		}

		if (_ladder && !_walking) {	// esta en escalera			
			transform.Translate (0, vely, 0);
			_rb.gravityScale = 0;
		} else {
			_rb.gravityScale = 1;
		}
	}



	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.collider.tag == "Platform"){
			Debug.Log ("Colision");
			_canJump = true;
		}
		if(coll.collider.tag == "Access Card"){
			HasCard = true;
		}
	}



	public void OnRightDown()
	{
		_dirx = 1;
		Debug.Log ("sss");
	}

	public void OnLeftDown()
	{
		_dirx = -1;
	}

	public void OnRightUp()
	{
		_dirx = 0;
	}

	public void OnLeftUp()
	{
		_dirx = 0;
	}



	public void OnUpUp()
	{
		_diry = 1;

		if (CanEnter) {
			_walking = false;
			_ladder = true;
			_rb.isKinematic = true;
		} else {
			SalirEscalera ();
		}
	}

	public void OnUpDown()
	{
		_diry = 0;
	}



	public void Jump()
	{
		if(_canJump){
			_rb.AddForce(new Vector2(0,JumpForce));
			_canJump = false;
		}
	}


	public void SalirEscalera() {
		_walking = true;
		_ladder = false;
		_rb.gravityScale = 1;
		_rb.isKinematic = false;
	}

    public void VolverPuntoInicio()
    {
        transform.position = _gc.PuntoInicio.position;
    }
}
