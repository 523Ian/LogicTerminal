using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Persistente : MonoBehaviour 
{
    public int Niveles = 2;
    public string Nombre;

    public static Persistente instancia;


    void Awake()
    {
        if(instancia == null)
        { // esto se ejecuta una sola vez en todo el programa.
            instancia = this;
            DontDestroyOnLoad(gameObject);

            CargarDatos();
        } else{
            Destroy(gameObject);
        }
    }

	void Start () 
    {
           
	}
	
	void Update () 
    {
	}


    void GuardarDatos() 
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream archivo = File.Create(Application.persistentDataPath + "/datos_jugador.dat");

        DatosDeJugador datos = new DatosDeJugador();
        datos.Niveles = Niveles;
        datos.Nombre  = Nombre;

        bf.Serialize(archivo, datos);
        archivo.Close();
    }


    void CargarDatos()
    {
        string nombreArch = Application.persistentDataPath + "/datos_jugador.dat";

        if(File.Exists(nombreArch)){
            BinaryFormatter bf = new BinaryFormatter();
            FileStream archivo = File.Open(nombreArch, FileMode.Open);

            DatosDeJugador datos = (DatosDeJugador)bf.Deserialize(archivo);
            archivo.Close();

            Niveles = datos.Niveles;
            Nombre = datos.Nombre;
        }
    }


    void OnGUI()
    {
        if(GUI.Button(new Rect(100,100, 300,100), "CARGAR DATOS")) {
            CargarDatos();
        }

        if(GUI.Button(new Rect(100,200, 300,100), "GUARDAR DATOS")) {
            GuardarDatos();
        }
    }
}


[Serializable]
class DatosDeJugador
{
    public int Niveles;
    public string Nombre;
}
