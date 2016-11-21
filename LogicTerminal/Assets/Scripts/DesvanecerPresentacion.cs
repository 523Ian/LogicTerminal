using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class DesvanecerPresentacion : MonoBehaviour 
{
    public Image Imagen;
    public Text Texto;
    public GameObject Botones;

    float p;

	void Start () 
    {
        p = 1;
	}
	
	void Update () 
    {
        p = p - Time.deltaTime*0.3f;
        Color c = Imagen.color;
        Imagen.color = new Color(c.r, c.g, c.b, p);

        if(p < 0)
        {
            Botones.SetActive(true);
            Destroy(gameObject);
        }
	
	}
}
