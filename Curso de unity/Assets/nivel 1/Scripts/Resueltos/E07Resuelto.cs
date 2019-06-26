using UnityEngine;
using System.Collections;

// ¡AVISO! No mires la solucion antes de intentar resolverlo por ti mismo.
// Si no, este curso no tendra tanto efecto como deberia.
// Los ejercicios sin hacer estan en la carpeta "Ejercicios". :)

public class E07Resuelto : MonoBehaviour {
	
	// Ejercicios capitulo 07. Operadores aritmeticos y de asignacion.
	
	// Ejercicio 1. Manejando puntuaciones.
	// Sigue las instrucciones paso a paso dentro de "Start".
	
	/*
	
	void Start () {
		
		// 1a. Define la variable "puntuacionJugador1" con el valor
		// entero 10:
		int puntuacionJugador1 = 10;
		
		// 1b. Define la variable "puntuacionJugador2" con el
		// valor de "puntuacionJugador1":
		int puntuacionJugador2 = puntuacionJugador1;
		
		// 1c. Incrementa en 5 el contenido de la variable "puntuacionJugador1":
		puntuacionJugador1 = puntuacionJugador1 + 5;
		
		// 1d. Haz que "puntuacionJugador2" duplique el valor que contiene:
		puntuacionJugador2 = puntuacionJugador2 * 2;
		
		// 1e. Saca por log el valor de "puntuacionJugador1" y "puntuacionJugador2":
		Debug.Log(puntuacionJugador1);
		Debug.Log(puntuacionJugador2);
		
		// 1f. Haz que se ejecute este script y comprueba que en el
		// log tienes los valores: 15, 20.
		
		// 1g. Depura paso a paso el codigo anterior y observa en cada momento el
		// valor de las dos variables y como se van actualizando. (Usare la ventana Locals)

	}
	
	*/
	
	// Ejercicio 2. Edades y cadenas de texto
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 2a. Define una variable entera llamada "edadJose" con el valor 10:
		int edadJose = 10;
		
		// 2b. Define una variable entera llamada "edadMaria" con la mitad de "edadJose":
		int edadMaria = edadJose / 2;
		
		// 2c. Decrementa un año las dos variables:
		edadJose = edadJose - 1;
		edadMaria = edadMaria - 1;
		
		// 2d. Saca por log el contenido de las dos variables:
		Debug.Log(edadJose);
		Debug.Log(edadMaria);		
		
		// 2e. Haz que se ejecute este script y comprueba que obtienes: 9, 4.		
		
		// 2f. Depura paso a paso observando el contenido de las dos variables en cada
		// momento. (Yo usare la ventana Watch)
		
		// 2g. Define dos variables de tipo cadena de texto llamadas "textoEdadJose" y
		// "textoEdadMaria", iniciando cada una a "Edad de Jose: " y "Edad de Maria: ", 
		// concatenandole detras con el operador "+" la variables de cada uno que contiene su edad:
		// Mientras uno de los dos elementos sea una cadena de texto, el operador "+" servira
		// para unir los valores en una sola cadena de texto resultante.
		string textoEdadJose = "Edad de Jose: "+edadJose;
		string textoEdadMaria = "Edad de Maria: "+edadMaria;
		
		// 2h. Saca por log el contenido de las variables "textoEdadJose" y "textoEdadMaria":
		Debug.Log(textoEdadJose);
		Debug.Log(textoEdadMaria);
		
		// 2i. Haz que se ejecute este script y comprueba que obtienes el siguiente resultado.
		// Edad de Jose: 9
		// Edad de Maria: 4
	}
	
	*/
	
	// Ejercicio 3. Hay que usar parentesis.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 3a. Haz que se ejecute este codigo y observa el resultado 11.
		// que no tiene nada que ver con hacer las operaciones de izquierda
		// a derecha, ya que asi obtendriamos 19.
		
		int res = (2 + 1) * (5 + 4);	
		Debug.Log("Resultado de la operacion: " + res);
		
		// 3b. Utiliza parentesis en la expresion anterior para que el resultado
		// de sumar 2 y 1 sea multiplicado por el resultado de la suma de 5 y 4.
		// Obteniendo en "res" el valor 27.
		
		// 3c. Observa que ocurre si quitamos el \n que hay dentro de la cadena del log.
	}
	
	*/
	
	// Ejercicio 4. Sucesión de Fibonacci.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 4a. Define un array de 5 enteros inicializados a cero:
		//int[] array = new int[5];
		int[] array = {0, 0, 0, 0, 0};
		
		// 4b. Asigna a la primera posicion (la [0]) el valor 1:
		array[0] = 1;
		
		// 4c. Asigna a la segunda posicion (la [1]) el valor 2:
		array[1] = 2;
		
		// 4d. Asigna a la tercera posicion (la [2]) el valor de la suma de las dos posiciones anteriores:
		array[2] = array[1] + array[0];
		
		// 4e. Asigna a la cuarta posicion (la [3]) el valor de la suma de las dos posiciones anteriores:
		array[3] = array[2] + array[1];
		
		// 4f. Asigna a la quinta posicion (la [4]) el valor de la suma de las dos posiciones anteriores:
		array[4] = array[3] + array[2];
			
		// 4g. Saca por log los cinco valores separados por comas:
		// Pista: variable1 + ", " + variable2 + ", " + variable3
		Debug.Log(array[0] + ", " + array[1] + ", " + array[2] + ", " + array[3] + ", " + array[4]);
		
	}
	
	*/	
	
	// Ejercicio 5. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 3 errores!
	
	/*

	void Start () {	
		
		// Sumamos 5 y 2, y a su resultado lo multiplicamos por 3.
		int valor = (5 + 2 * 3);
		// Concatenamos a la cadena "Resultado: " el valor de la variable "valor".
		Debug.Log("Resultado: " + valor);
	}
	
	*/	
	
}
