using UnityEngine;
using System.Collections;

public class T03 : MonoBehaviour {

	// Utilizar esto para la inicializacion
	void Start () {
	
		// Empezamos a sacar palabras por consola
		Debug.Log("Primero");
		
		/* Esto es
		un ejemplo
		de comentario
		multilinea.
		Unity ignorara
		todo lo que
		haya a partir
		de la /*, hasta
		que se encuentre
		con un */
		Debug.Log("Segundo");	// Esta linea saca la palabra "Segundo" por consola.
		Debug.Log("Tercero");
		Debug.Log("Cuarto");
		
		// Esta es la ultima linea
		Debug.Log("Quinto");
	}

}
