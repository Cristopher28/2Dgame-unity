using UnityEngine;
using System.Collections;

public class E06 : MonoBehaviour {

	// Ejercicios capitulo 06. Definiendo arrays.
	
	// Ejercicio 1. Definiendo arrays y actualizando sus valores.
	// Sigue las instrucciones paso a paso dentro de "Start".

	void Start () {

		// 1a. Define una variable de tipo array de tres valores logicos
		// todos inicializados a falso. (Representando que todavia
		// no hemos completado ninguno de los tres niveles):
		
				
		// 1b. Marca como completado el primer nivel, es decir,
		// el valor de la primera posicion del array:
		
		
		// 1c. Saca por log el valor de cada una de las 
		// tres casillas dentro del array definido:
		
		
		// 1d. Haz que se ejecute este script y comprobar que 
		// obtenemos: true, false, false.
	}
	
	// Ejercicio 2. Definiendo arrays y actualizando sus valores.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 2a. Define una variable de tipo array de cinco valores enteros
		// todos inicializados al valor 1:
		
		
		// 2b. Saca por log el numero de elementos que tiene el array:
		// Pista: .Length
		
		
		// 2c. Cambia el valor de la primera y ultima posicion por el numero 42:
		
		
		// 2d. Saca por log el valor de cada una de las cinco casillas del array:
		
		
		// 2e. Haz que se ejecute este script y comprueba que se obtienen
		// los valores: 5, 42, 1, 1, 1, 42.
		
		// 2f. Depura el codigo anterior y observa como cambia el contenido
		// del array cuando se le asigna el valor 42 a la primera y ultima posicion.
		// (Para hacer el seguimiento de los datos del array yo usare el metodo de 
		// mantener el cursor sobre la variable y una vez aparezca la informacion, 
		// hare clic sobre el pin rojo para que no desaparezca. Movere la caja a donde 
		// no moleste y la desplegare para ver todo el contenido)
		
	}
	
	*/
	
	// Ejercicio 3. Galleta de la suerte.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 3a. Define una variable array de 5 cadenas de texto, inicializadas
		// con cinco mensajes que digan predicciones del futuro:
		
		
		// Esta linea genera un numero entero aleatorio entre 0 y 4,
		// (incluyendo el 0 y el 4) y lo guarda en la variable llamada
		// "numeroAleatorio".
		// NOTA: No tienes por que entender todavia su funcionamiento
		// Por eso mismo dejo esta linea ya hecha.
		int numeroAleatorio = Random.Range(0, 5);
		
		// 3b. Saca por log el valor almacenado en la posicion "numeroAleatorio":
		
		
		// 3c. Haz que se ejecute este script varias veces y comprueba que
		// cada vez aparece una frase distinta.
		
		// 3d. Depura este script para ver el valor que se le asigna a
		// "numeroAleatorio" cada vez que se ejecuta. (Para ver su valor, yo mantendre 
		// el cursor sobre la variable una vez se le haya asignado el valor)	
	}
	
	*/
	
	// Ejercicio 4. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// En este caso no tendras un error de compilacion. El error
	// aparecera una vez hagas que este script se ejecute. 
	// Observa el error y fijate en la linea donde se da.
	// Corrigelo para que no ocurra.
	
	/*

	void Start () {	
		
		int[] puntuacionesMaximas = {99, 97, 96, 94, 90};
		Debug.Log(puntuacionesMaximas[0]);
		Debug.Log(puntuacionesMaximas[1]);
		Debug.Log(puntuacionesMaximas[2]);
		Debug.Log(puntuacionesMaximas[3]);
		Debug.Log(puntuacionesMaximas[4]);
		Debug.Log(puntuacionesMaximas[5]);
		
	}
	
	*/
	
}
