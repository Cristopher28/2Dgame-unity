using UnityEngine;
using System.Collections;

public class T05 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		// Tipos de datos:
		
		// Numeros enteros: int
		// 1, 4, 10, -5, -1000, 0, etc.
		
		// Numeros reales: float
		// 3.1415f, 0.5f, 99.99f, -45.75f, etc.
		
		// Cadenas de texto: string
		// "Hola mundo!", "Antonio", "Maria", etc.
		
		// Valores logicos: bool
		// true == verdadero, false == falso
		
		// Ejemplos de declaracion de variables
		int puntos = 0;
		float notaExamen = 9.75f;
		string nombreJugador = "Juande";
		bool personajeVivo = true; 
		
		Debug.Log(puntos);
		Debug.Log(notaExamen);
		Debug.Log(nombreJugador);
		Debug.Log(personajeVivo);
		
		string mensaje = "Este es \\ un mensaje \"especial\"\nEsta es una nueva linea";
		Debug.Log(mensaje);
		
		// Para definir variables del mismo tipo en una sola linea
		//int edadManolo = 20, edadPaco = 18, edadLuis = 21;
		
		// Modificar el contenido de una variable "="
		puntos = 100;
		personajeVivo = false;
		
		// Aqui la variable "puntos" ya valdra 100
		
		Debug.Log(puntos);
		
		puntos = 200;
		personajeVivo = true;
		
		// Aqui la variables "puntos" ya valdra 200
		
		Debug.Log(puntos);
		
		// Ambitos de variables
		{
			int a = 0;	
			Debug.Log(a);
			{
				int b = 1;
				Debug.Log(a);
				Debug.Log(b);
			}
			// Aqui la variable "b" ya no existiria y esta
			// instruccion daria un error: Debug.Log(b);		
		}
		// Aqui la variable "a" ya no existiria y esta
		// instruccion daria un error: Debug.Log(a);
		
	}

}
