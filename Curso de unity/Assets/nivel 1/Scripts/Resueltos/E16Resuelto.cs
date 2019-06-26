using UnityEngine;
using System.Collections;

// ¡AVISO! No mires la solucion antes de intentar resolverlo por ti mismo.
// Si no, este curso no tendra tanto efecto como deberia.
// Los ejercicios sin hacer estan en la carpeta "Ejercicios". :)

public class E16Resuelto : MonoBehaviour {
	
	// Ejercicios capitulo 16. Metodos. Definicion y uso.
	
	// Ejercicio 1. Llamada sencilla.
	// Sigue las siguientes instrucciones paso a paso:
	
	/*
	
	// 1a. Define justo debajo de este comentario un metodo
	// que tenga por nombre "Saludar", que lo que haga es
	// sacar por pantalla el texto "Hola! Como estas?":
	void Saludar(){
		Debug.Log("Hola! Como estas?");
	}
	
	void Start () {
	
		// 1b. Usando un bucle "for" haz 5 llamadas al
		// metodo "Saludar":
		for(int c=1; c<=5; c++){
			Saludar();
		}
		
		// 1c. Haz que se ejecute este script y comprueba que por
		// el log salen cinco lineas con el saludo.
		
		// 1d. Depura paso a paso este script observando que linea se
		// va ejecutando en cada momento usando unicamente "Step Over". 
		// Luego, depuralo de igual forma (con "Step Over"), pero
		// en el momento de ejecutar la linea que hace la llamada a
		// saludar, pulsa el boton "Step Into". (Para depurar el codigo
		// que este metodo contiene)
		// Observa que si estas en la llamada a un metodo, si pulsas
		// "Step Over" se ejecutara todo el codigo de ese metodo como
		// si fuera una sola instruccion; y si pulsas "Step Into", el
		// depurador ira a depurar paso a paso el codigo de ese metodo.
		// NO PULSES "Step Into" en metodos que no sean de tu codigo,
		// como por ejemplo: Debug.Log(...)
		
	}
	
	*/
	
	// Ejercicio 2. Metodo con mas de una linea de codigo.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las siguientes instrucciones paso a paso.
	
	/*
	
	// 2a. Define un metodo llamado "MuestraNumeros" que lo que haga
	// sea sacar por pantalla los numeros del 1 al 5 usando un bucle:
	void MuestraNumeros(){
		for(int c=1; c<=5; c++){
			Debug.Log(c);
		}
	}

	void Start () {
		
		// 2b. Saca por log el texto "Primera lista:":
		Debug.Log("Primera lista:");
		
		// 2c. Haz una llamada al metodo "MuestraNumeros":
		MuestraNumeros();
		
		// 2d. Saca por log el texto "Segunda lista:":
		Debug.Log("Segunda lista:");
		
		// 2e. Haz una llamada al metodo "MuestraNumeros":
		MuestraNumeros();
		
		// 2f. Haz que se ejecute este script y comprueba que por log tienes
		// Primera lista:
		// 1
		// 2
		// 3
		// 4
		// 5
		// Segunda lista:
		// 1
		// 2
		// 3
		// 4
		// 5
		
		// 2g. Depura paso a paso este script y practica con el boton "Step Into"
		// cuando estes para ejecutar la llamada al metodo "MuestraNumeros".
		// Ejecuta paso a paso el codigo de ese metodo y prueba a pulsar el boton
		// "Step Out" cuando estas en mitad del codigo del mismo (del metodo). Observa
		// que ocurre, donde se vuelve a parar el depurador despues de pulsar
		// ese boton.
	}
	
	*/
	
	// Ejercicio 3. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 9 errores!
	
	/*
	
	void ContarDel10Al0(){
		for(int c = 1 ; c <= 10 ; c++){
			Debug.Log(c);
		}
	}

	void Start () {	
	
		Debug.Log("Iniciamos la cuenta...");
		ContarDel10Al0();
		Debug.Log("Fin de la cuenta!");	
	
	}
	
	*/
	
}
