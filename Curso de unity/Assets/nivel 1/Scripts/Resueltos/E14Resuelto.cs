using UnityEngine;
using System.Collections;

// ¡AVISO! No mires la solucion antes de intentar resolverlo por ti mismo.
// Si no, este curso no tendra tanto efecto como deberia.
// Los ejercicios sin hacer estan en la carpeta "Ejercicios". :)

public class E14Resuelto : MonoBehaviour {
	
	// Ejercicios capitulo 14. FOREACH.
	
	// Ejercicio 1. Recorriendo el contenido de un array.
	// Sigue las instrucciones paso a paso dentro de "Start".
	
	/*
	
	void Start () {
		
		// 1a. Define un array llamado "valores" inicializado a
		// los siguientes valores: 2, 3, 5, 7, 11, 13:
		int[] valores = {2, 3, 5, 7, 11, 13};
		
		// 1b. Recorre todos los elementos del array "valores"
		// usando un bucle "foreach" y ve sacandolos por log:
		foreach(int valor in valores){
			Debug.Log(valor);
		}
		
		// 1c. Haz que se ejecute este script y observa que de
		// resultado obtienes una salida por log de cada elemento
		// del array. Luego, depuralo paso a paso observando que lineas
		// se van ejecutando y los valores de cada variable en cada momento.
		
	}
	
	*/
	
	// Ejercicio 2. Recomponiendo el mensaje.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 2a. Define una variable "frase" de tipo cadena de texto
		// inicilizada a cadena vacia:
		// Pista: Una cadena vacia es: "" (Sin nada dentro)
		string frase = "";
		
		// 2b. Define un vector (array) de cadenas de texto llamado "mensajes"
		// inicializado con el siguiente conjunto de textos:
		// "Hazlo "
		// "o no lo hagas. "
		// "Pero no lo intentes."
		string[] mensajes = {"Hazlo ", "o no lo hagas. ", "Pero no lo intentes."};
		
		// 2c. Usando un bucle foreach, recorre todos los elementos del
		// array y ve concatenandolo al final de la variable "frase" para
		// asi recomponer la frase:
		foreach(string mensaje in mensajes){
			frase = frase + mensaje;	// frase += mensaje;
		}
		
		// 2d. Saca por log el contenido de la variable "frase":
		Debug.Log(frase);
		
		// 2e. Haz que se ejecute este script y observa que sale por log la frase
		// entera: "Hazlo o no lo hagas. Pero no lo intentes.". Luego, depura paso
		// a paso este script observando las lineas que se ejecutan en cada paso y
		// el contenido de cada variable en cada momento.		
	}
	
	*/
	
	// Ejercicio 3. Llevar la cuenta de elementos.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 3a. Define un array llamado "valores" inicializado a
		// los siguientes valores: 2, 3, 5, 7, 11, 13:
		int[] valores = {2, 3, 5, 7, 11, 13};
		
		// 3b. Define una variable entera llamada "numeroElementoVuelta"
		// inicializandola a 1:
		int numeroElementoVuelta = 1;
		
		// 3c. Recorre todos los elementos del array "valores" y ve
		// sacandolos por log. El formato del mensaje de
		// salida debera ser como el siguiente:
		// Vuelta A : B
		// Sabiendo que en la posicion de A hay que indicar el numero
		// de vuelta en el bucle empezando por 1.(Vuelta 1, vuelta 2, etc)
		// Y B es el valor de ese elemento del array en esa vuelta.
		foreach(int valor in valores){
			Debug.Log("Vuelta "+numeroElementoVuelta+" : "+valor);
			numeroElementoVuelta++;
		}
		
		
		// 3d. Haz que se ejecute este script y comprueba que la salida
		// es la correcta. Aprovecha para depurar paso a paso y observar
		// la ejecucion y variables en cada paso.
	}
	
	*/
	
	// Ejercicio 4. Pasar elementos de un array a otro. Uso del "for" y "foreach".
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 4a. Define un vector (array) de cadenas llamado "textosNormales" con
		// los valores: "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete"
		// "Ocho", "Nueve", "Diez":
		string[] textosNormales = {"Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez"};
		
		// 4b. Define un vector (array) de 10 cadenas de texto llamado
		// "textosInvertidos". Solo define el vector de 10 cadenas de texto:
		// Pista: new string[10];
		string[] textosInvertidos = new string[10];
		
		// 4c. Usando un bucle "for" y dos variables contador, una que vaya
		// desde el 0 hasta el 9, y otra que vaya desde el 9 hasta el 0, copia todos
		// los elementos del array "textosNormales" al array "textosInvertidos" de
		// forma que "textosInvertidos" tenga los elementos en el orden inverso.
		// Su primer elemento seria "Diez", el segundo "Nueve", el tercero "Ocho", etc.:
		for(int contadorNormal = 0, contadorInvertido = 9; contadorNormal <= 9; contadorNormal++, contadorInvertido--){
			textosInvertidos[contadorInvertido] = textosNormales[contadorNormal];
		}
		
		// 4d. Usando un bucle "foreach" recorre todos los elementos del vector (array)
		// "textosInvertidos" y sacalos por log:
		foreach(string texto in textosInvertidos){
			Debug.Log(texto);
		}
		
		// 4e. Haz que se ejecute este script y comprueba que salen 10 logs con las
		// palabras que corresponden a los numeros desde el 10 hasta el uno. Depura paso
		// a paso el codigo anterior y observa en todo momento que lineas se ejecutan y
		// el contenido de las variables.
		
	}	
	
	*/
	
	// Ejercicio 5. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 7 errores!
	
	/*

	void Start () {	
		
		float[] notasExamenes = { 5.5f, 6.75f, 8.25f, 7f, 5.9f };
		float suma = 0f;
			
		foreach(float nota in notasExamenes){
				suma += nota;
		}
	
		// Calculamos la media dividiendo la suma total entre el numero de elementos.
		float media = suma / notasExamenes.Length;
		
		Debug.Log("La media de las notas es: " + media);
	}
	
	*/

}
