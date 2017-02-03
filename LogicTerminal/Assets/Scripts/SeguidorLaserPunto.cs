using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SeguidorLaserPunto : MonoBehaviour 
{
    LineRenderer _rend;
    Animator _anim;

    public Transform Punto;

	public int escena;

	void Start () 
    {
        _rend = GetComponent<LineRenderer>();
        _rend.useWorldSpace = true;

        _anim = GetComponent<Animator>();
	}
	
	void Update () 
    {
        Vector3 v = transform.position;
        v = new Vector3(v.x, v.y, -1);

        _rend.SetPosition(0, v);

        v = Punto.position;
        v = new Vector3(v.x, v.y, -1);

        _rend.SetPosition(1, Punto.position);
	
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        if(c.tag == "Player")
        {
            _anim.SetTrigger("ActivarJaula"); 

        }
    }

    public void JaulaCaida()
    {
        StartCoroutine (Reiniciar ());
    }


    IEnumerator Reiniciar()
    {
        yield return new WaitForSeconds (3f);
		SceneManager.LoadScene ("Level_" + escena);
    }
}
