using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SeguidorLaserPunto : MonoBehaviour 
{
    LineRenderer _rend;
    Animator _anim;

    public Transform Punto;

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
        int nivel = Persistente.instancia.NivelActual;

        string nombreNivel = "Level_" + nivel;

        yield return new WaitForSeconds (3f);

        GameObject.FindGameObjectWithTag("Player").GetComponent<mover>().VolverPuntoInicio();

        SceneManager.UnloadScene(nombreNivel);
        SceneManager.LoadScene(nombreNivel, LoadSceneMode.Additive);
    }
}
