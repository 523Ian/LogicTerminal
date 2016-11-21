using UnityEngine;
using System.Collections;

public class MoveTeclado : MonoBehaviour {

	Rigidbody2D _rb;
	bool _walking;
	bool _ladder;
	bool _canJump;

	public float JumpForce = 300;
	public float Velocidad = 6;

	void Start () 
	{
		_rb = GetComponent<Rigidbody2D> ();

		_walking = true;
		_canJump = true;
		_ladder = false;

	}
	
	void Update () {
		float h = Input.GetAxis ("Horizontal") * Velocidad * Time.deltaTime;
		float v = Input.GetAxis ("Vertical") * Velocidad * Time.deltaTime;
		bool Salto = Input.GetButton ("Jump");

		if(_walking){
			transform.Translate (h, 0, 0);

			_rb.gravityScale = 1;
			_rb.isKinematic = false;
		}

		if (_ladder && !_walking) {	// esta en escalera			
			transform.Translate (0, v, 0);
		}

		if(Salto && _canJump){
			_rb.AddForce(new Vector2(0,JumpForce));
			_canJump = false;
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.collider.tag == "Platform"){
			_canJump = true;
		}
	}
}
