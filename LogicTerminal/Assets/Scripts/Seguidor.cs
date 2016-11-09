using UnityEngine;
using System.Collections;

public class Seguidor : MonoBehaviour 
{
	Transform _player;
	Vector3 _posIni;
	Vector3 _movimiento;

	public Vector3 Movimiento
	{
		get{ return _movimiento; }
	}

	public float Smoothness;

	void Start () 
	{
		_player = GameObject.FindGameObjectWithTag ("Player").transform;

		_posIni = transform.position;
	}




	void Update () 
	{
		Vector2 pos = new Vector2 (transform.position.x, transform.position.y);
		Vector2 posPlayer = new Vector2 (_player.position.x, _player.transform.position.y);

		pos = Vector2.Lerp (pos, posPlayer, Smoothness * Time.deltaTime);

		transform.position = new Vector3 (pos.x, pos.y, transform.position.z);

		_movimiento = transform.position - _posIni;
	}
}
