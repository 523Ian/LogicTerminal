using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour 
{
    Animator _anim;

    void Start()
    {
        _anim = GetComponent<Animator>();
    }


    public void HacerSwitch(bool estaActivo)
	{
        GameObject [] terminales = GameObject.FindGameObjectsWithTag("Terminal");

        for(int i=0;i<terminales.Length;i++) {
            Terminal t = terminales[i].GetComponent<Terminal>();
            if(t.Switch == this){
                t.MostrarActivo(estaActivo);
            }
        }


        _anim.SetTrigger("Switch");
	}
}
