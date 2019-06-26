using UnityEngine;
using System.Collections;

public class E03 : MonoBehaviour {

	// Ejercicios capitulo 03. Trabajando con comentarios.
	
	// El texto de todos los scripts de los ejercicios no tiene tildes debido 
	// a que la version de Monodevelop que estoy usando no me deja escribirlas.
	// con tildes. De hecho, no me aparecen aunque las haga por escribir.
	// (Podria usar otro editor, pero para este curso prefiero centrarme en este)

	void Start () {
	
		// 1. Comenta las lineas que sacan por log el texto "Ola ke ase?"
		// para que al ejecutarse este script, solo salga por log el texto:
		// Luke,
		// yo soy
		// tu padre.

		Debug.Log("Ola ke ase?");
		Debug.Log("Luke, ");
		Debug.Log("Ola ke ase?");
		Debug.Log("Ola ke ase?");
		Debug.Log("Ola ke ase?");
		Debug.Log("Ola ke ase?");
		Debug.Log("Ola ke ase?");
		Debug.Log("Ola ke ase?");
		Debug.Log("Ola ke ase?");
		Debug.Log("Ola ke ase?");		
		Debug.Log("yo soy");
		Debug.Log("Ola ke ase?");
		Debug.Log("tu padre.");
		Debug.Log("Ola ke ase?");
		
		// 2. Depura paso a paso el codigo anterior con los "Ola ke ase?" comentados
		// para ver que estos no se tienen en cuenta.
	}
}
