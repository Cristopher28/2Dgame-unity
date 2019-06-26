using UnityEngine;
using System.Collections;

public class E08 : MonoBehaviour {
	
	// Ejercicios capitulo 08. Operadores logicos y de comparacion.
	
	// Ejercicio 1. Operador logico de negacion.
	// Sigue las instrucciones paso a paso dentro de "Start".
	
	void Start () {
		
		// 1a. Define una variable logica llamada "a" con el valor true:
		
		
		// 1b. Define una variable logica llamada "b" con el valor de aplicar
		// el operador "!" a la variable "a":
		// Pista: !a
		
		
		// 1c. Saca por log el contenido de la variable "b":
		
		
		// 1d. Haz que se ejecute este script y observa lo que hace el operador "!".
		
		// 1e. Cambia el valor de inicializacion de la variable "a" a false y vuelve
		// a hacer que se ejecute este script observando lo que hace el operador "!".
		
		// 1f. Cambia la linea que escribiste en el paso 1b, y en vez de poner un "!"
		// pon dos juntos. Pista: !!a. Adivina que valor saldra ahora cuando se ejecute este script.
	}
	
	// Ejercicio 2. Operadores AND (&&) y OR (||)
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {

		bool trueANDtrue = true && true;		
		bool trueANDfalse = true && false;		
		bool falseANDtrue = false && true;		
		bool falseANDfalse = false && false;	
		
		Debug.Log("true && true = "+trueANDtrue);
		Debug.Log("true && false = "+trueANDfalse);
		Debug.Log("false && true = "+falseANDtrue);
		Debug.Log("false && false = "+falseANDfalse);
		
		bool trueORtrue = true || true;			
		bool trueORfalse = true || false;		
		bool falseORtrue = false || true;		
		bool falseORfalse = false || false;		
		
		Debug.Log("true || true = "+trueORtrue);
		Debug.Log("true || false = "+trueORfalse);
		Debug.Log("false || true = "+falseORtrue);
		Debug.Log("false || false = "+falseORfalse);
		
		// 2a. Analiza el codigo anterior y adivina que valores saldran por el log.
		// Apunta los resultados en una hoja de papel antes de hacer que se
		// ejecute este codigo y ver los resultados.
		// NO HAGAS CASO DE LAS ADVERTENCIAS QUE DARA EL COMPILADOR.

	}
	
	*/
	
	// Ejercicio 3. Operaciones !, AND (&&) y OR (||) combinadas
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		bool estoyProgramando = true;
		bool vivoEnMarte = false;
		bool YoutubeEmpiezaPorY = true;
		
		bool resultado1 = estoyProgramando && !vivoEnMarte;
		bool resultado2 = vivoEnMarte || (estoyProgramando && YoutubeEmpiezaPorY);
		bool resultado3 = !((!estoyProgramando || vivoEnMarte) || !YoutubeEmpiezaPorY);
		
		Debug.Log("Resultado 1: "+resultado1);
		Debug.Log("Resultado 2: "+resultado2);
		Debug.Log("Resultado 3: "+resultado3);
		
		// 3a. Analiza el codigo anterior y adivina que valores saldran por el log.
		// Apunta los resultados en una hoja de papel antes de hacer que se
		// ejecute este codigo y ver los resultados.
		
		// 3b. Depura el codigo anterior poniendo un punto de ruptura en el primer Debug.Log.
		// Luego en la ventana de Watch, añade cualquier expresion logica que quieras ver
		// a que valor se evalua. Ejemplo:
		// !vivoEnMarte
		// vivoEnMarte || estoyProgramando
		// vivoEnMarte || (estoyProgramando && YoutubeEmpiezaPorY)
		
	}
	
	*/
	
	// Ejercicio 4. Edades y comparaciones
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.

	/*

	void Start () {
		
		// 4a. Define una variable entera llamada "edad" inicializada con el valor 17:
		
		
		// 4b. Define una variable logica llamada "dentroDelIntervalo" que diga si el valor de
		// la variable "edad" esta comprendido entre los 18 y 30 años (Incluyendo el 18 y el 30):
		// Pista: Usaras los operadores "=", "&&", ">=" y "<=".
				
		
		// 4c. Sacamos por log si el valor esta dentro el intervalo. 
		// Pista:
		// Debug.Log("¿Esta el valor " + edad + " comprendido entre los 18 y 30 años? --> " + dentroDelIntervalo);
		
		
		// 4d. Define una variable logica llamada "fueraDelIntervalo" que diga si el valor de
		// la variable "edad" ESTA FUERA del intervalo [18, 30] utilizando los operadores
		// "=", "||", ">" y "<":
		// El camino facil es haciendo:
		// bool fueraDelIntervalo = !dentroDelIntervalo;
		// En este caso lo vamos a hacer usando los operadores que se han mencionado.
		
		
		// 4e. Saca por log si el valor esta fuera del intervalo. Puedes fijarte del Debug.Log anterior,
		// pero cambiando el texto y la variable:
		
		
		// 4f. Adivinar el resultado que tendremos en las dos variables logicas con la variable edad a 17
		// despues de hacer que se ejecute este script.
		
		// 4g. Modificar el valor de inicializacion de la variable "edad" a 18 y adivinar que valores
		// obtendremos en las dos variables logicas. Luego hacer que se ejecute este script y ver si
		// lo hemos adivinado bien.
		
		// 4h. Igual que antes, pero con el valor de "edad" a 31.
		
	}
	
	*/
	
	// Ejercicio 5. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 4 errores!
	
	/*

	void Start () {	
		
		bool esDeDia = true
		bool vivoEnMarte == false;
		int edad = 20;
		
		bool resultado = ((esDeDia || vivoEnMarte);
		bool noTiene20 = !(edad = 20);
		
		Debug.Log("Resultado: "+resultado+" NoTiene20: "+noTiene20);
	}
	
	*/
	
}
