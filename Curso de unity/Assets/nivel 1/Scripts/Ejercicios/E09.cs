using UnityEngine;
using System.Collections;

public class E09 : MonoBehaviour {
	
	// Ejercicios capitulo 09. Mas operadores: ++, -- y ?:
	
	// Ejercicio 1. Incrementando variables de uno en uno.
	// Sigue las instrucciones paso a paso dentro de "Start".
	
	void Start () {
		
		// 1a. Define una variable entera inicializada a cero:
		
		
		// 1b. Incrementa esa variable en uno usando los operadores "=" y "+":
		
		
		// 1c. Incrementa esa variable en uno usando el operador "+=":
		
		
		// 1d. Incrementa esa variable en uno usando el operador "++":
		
		
		// 1e. Saca por log el valor de la variable:
		
		
		// 1f. Haz que se ejecute este script para comprobar si se obtiene 3 en el log.		
		
	}
	
	// Ejercicio 2. Operador --.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 2a. Define una variable "a" entera con el valor 10:
		
		
		// 2b. Define una variable "b" entera con el valor de "a", 
		// y coloca el operador "--" a la variable "a" de forma que
		// tras ejecutarse esta linea, en "b" quede el valor 10 y 
		// en "a" el valor "9":
		
		
		// 2c. Saca por log el valor de ambas variables:
		// Pista: Debug.Log("a="+a+", b="+b);
		
		
		// 2d. Hacer que se ejecute este script y comprobar que "a"
		// vale 9 y "b" vale 10.
						
	}
	
	*/
	
	// Ejercicio 3. Operador ternario ?:.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 3a. Define una variable "edad" de tipo entero inicializada a 17:
		
		
		// 3b. Define una variable "texto" de tipo cadena de texto inicializandola
		// a "Mayor de edad" si "edad" es mayor o igual a 18; si no, 
		// inicializarla a "Menor de edad":
		
		
		// 3c. Sacar por log el contenido de "texto":
		
		
		// 3d. Hacer que se ejecute este script y comprobar que el texto que sale
		// por log es el texto "Menor de edad".
		
		// 3e. Cambiar el valor de "edad" para que se inicialize con el valor 19
		// y hacer que se ejecute este script para comprobar que el texto que sale
		// por log es el texto "Mayor de edad".
	}

	*/
	
	// Ejercicio 4. Adivina que pasara...
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		int cont = 0;
		
		int a = ++cont;
		int b = cont++;
		
		string texto = (a==1 && b==1 && cont==2) ? "Lo he entendido!" : "Sigo sin entenderlo... :(";
		
		Debug.Log(texto);
		
		// 4a. Adivinar que texto saldra por consola al hacer que se ejecute este script.
		
		// 4b. Depurar paso a paso inspeccionando en todo momento los valores de las variables: a, b y cont.
		
	}
	
	*/
	
	
	// Ejercicio 5. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 5 errores!
	
	/*

	void Start () {	
		
		// Definimos cont a 0
		int cont = 0;
		
		// Incrementamos cont en uno
		cont++
		
		// Sacamos por log "cont vale 2" si despues de incrementarlo vale 2
		// si no, sacariamos "cont no vale 2".
		Dabug.Log((++cont)==2) ? "cont vale 2" ; "cont no vale 2");
		
	
	*/
}
