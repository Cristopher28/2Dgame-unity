using UnityEngine;
using System.Collections;

public class T10 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		// Condicional IF (SI) / ELSE (SI NO)
		
		// if(Expresion que se resuelve en un valor logico) Instruccion a ejecutar en caso de que la expresion sea true
		// else Instruccion a ejecutar en caso de que la expresion sea false
		//
		// Expresion: true | false | variable logica | Comparacion...
		
		int edad = 18;
		if(edad >= 18){
				int a = 5;
				Debug.Log("Eres mayor de edad"); 
				Debug.Log("Instruccion adicional (true)"); 
				Debug.Log(a);
		}else if(edad <= 0){
			Debug.Log("Todavia no has nacido");
		}		
		
		Debug.Log("Programa finalizado!");
	}
	
}
