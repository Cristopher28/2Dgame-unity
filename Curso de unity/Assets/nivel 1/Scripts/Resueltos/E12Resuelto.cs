using UnityEngine;
using System.Collections;

// ¡AVISO! No mires la solucion antes de intentar resolverlo por ti mismo.
// Si no, este curso no tendra tanto efecto como deberia.
// Los ejercicios sin hacer estan en la carpeta "Ejercicios". :)

public class E12Resuelto : MonoBehaviour {
	
	// Ejercicios capitulo 12. Bucles WHILE - DO / WHILE.
	
	// Ejercicio 1. Repitiendo Debug.Log
	// Sigue las instrucciones paso a paso dentro de "Start".
	
	/*
	
	void Start () {
		
		// 1a. Define una variable entera "contador" inicializada a cero:
		int contador = 0;
		
		// 1b. Usando un bucle while y la variable "contador"
		// Haz que salga por log 10 veces el texto "Hola!":
		while(contador < 10){
			//Debug.Log("Hola!");
			Debug.Log("Hola! ("+contador+")");
			contador++;
		}
		
		// 1c. Haz que se ejecute este script y comprueba que has obtenido
		// exactamente 10 holas en el log.
		
		// 1d. Depura paso a paso el codigo anterior y observa su ejecucion
		// y el valor de sus variables en cada paso.
		
		// 1e. Modifica el codigo de la seccion 1b para que en vez de
		// mostrarse solo "Hola!" tambien se muestre el valor de "contador".
		// De forma que se vea tal que asi:
		// Hola! (0)
		// Hola! (1)
		// Hola! (2)
		// ...
		
		
		// 1f. Haz que se ejecute este script y comprueba que todo sale 
		// como esperabas.
		
	}
	
	*/
	
	// Ejercicio 2. Las tablas de multiplicar
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 2a. Define una variable entera "tablaDeMultiplicar" e inicializala a 5:
		int tablaDeMultiplicar = 9;
		
		// 2b. Define una variable entera llamada "contador" inicializandola a 1:
		int contador = 1;
		
		// 2c. Usando un while y la variable "contador" para el condicional, saca por log 
		// la tabla de multiplicar del numero que este almacenado en "tablaDeMultiplicar":
		// Ejemplo de como deberia salir las lineas por el log:
		// X * 1 = X
		// X * 2 = X
		// X * 3 = X
		// ...
		// X * 10 = X
		// (Sabiendo que la primera X de cada linea corresponde al lugar donde sacar el valor
		// de "tablaDeMultiplicar" y la ultima X de cada linea corresponde al resultado de
		// multiplicar "tablaDeMultiplicar" por el valor correspondiente.)
		while(contador<=10){
			Debug.Log(tablaDeMultiplicar+" * "+contador+" = "+(tablaDeMultiplicar * contador));
			contador++;
		}
		
		// 2d. Haz que se ejecute este script y comprueba que ha salido por log la
		// tabla del 5. Luego cambia el valor de inicializacion de "tablaDeMultiplicar"
		// por cualquier otro numero del 1 al 9 y comprueba que la tabla de multiplicar
		// que sale por log corresponde a la tabla de ese numero. 
		// (Si tuvieras algun problema, puedes iniciar una depuracion paso a paso y 
		// comprobar si todo va ejecutandose como deberia. Para eso esta la depuracion.)
	}
	
	*/
	
	// Ejercicio 3. Todas las tablas de multiplicar.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 3a. Basandote en el codigo del ejercicio anterior, haz que salga
		// por log todas las tablas de multiplicar, desde la del numero 1
		// hasta la del numero 10:
		// Pista: Igual que iteras X veces incrementando "contador", ahora
		// tendras que meter todo ese codigo en otro bucle para que se ejecute 
		// X veces, usando esta vez la variable "tablaDeMultiplicar".
		// Resumiendo: Tendras que hacer un bucle que vaya del 1 al 10, y
		// dentro de ese, otro que vaya del 1 al 10. Y dentro de este ultimo, la linea
		// que saca por log el texto. (Un bucle dentro de otro bucle)
		int tablaDeMultiplicar = 1;
		int contador = 1;
		
		while(tablaDeMultiplicar<=10){
			contador = 1;
			while(contador<=10){
				Debug.Log(tablaDeMultiplicar+" * "+contador+" = "+(tablaDeMultiplicar * contador));
				contador++;
			}
			tablaDeMultiplicar++;
		}
		
		// 3b. Haz que se ejecute este script y comprueba que tienes las
		// 10 tablas de multiplicar completas. (Si tienes problemas, usa el
		// depurador y cualquier forma de inspeccionar el valor de las variables)
	}
	
	*/
	
	// Ejercicio 4. Recorrer arrays
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 4a. Define un array de tipo cadenas de texto llamado "mensajes", que
		// contenga las siguientes cadenas de texto en su inicializacion:
		// "Esto es", "un ejemplo", "de como", "se pueden", "recorrer todos",
		// "los elementos", "de un array":
		string[] mensajes = {"Esto es", "un ejemplo", "de como", "se pueden", 
		"recorrer todos", "los elementos", "de un array", "Fin!"};
		
		// 4b. Recorre todos los elementos del array, sacando su contenido por log.
		// Pista: Recuerda que los arrays empiezan en la posicion 0 y tendras que
		// hacer que el bucle se repita hasta que llegues a la ultima posicion:
		// Recuerda que para saber el total de elementos que tiene "mensajes"
		// tendras que escribir: mensajes.Length (y que si el total de elementos
		// de un array es por ejemplo 10, la ultima posicion para acceder en el
		// array sera la numero 10-1=9 debido a que se empieza a contar desde 0)
		int cont = 0;
		while(cont < mensajes.Length){
			Debug.Log(mensajes[cont]);
			cont++;
		}
		
		// 4c. Haz que se ejecute este script y comprueba que salen exactamente
		// las 7 cadenas de texto del array. (Si tuvieras problemas, usa el
		// depurador y el inspector de variables)
		
		// 4d. Añade a la inicializacion del array "mensajes" otro mensaje al final
		// con el texto que tu quieras. Luego haz que se ejecute este script y
		// comprueba que salen las 8 cadenas de texto que tiene el mismo.
		
	}
	
	*/	
	
	// Ejercicio 5. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 5 errores!
	// Una vez corregidos todos los errores depura el codigo
	// y observa como en cada vuelta del bucle se va añadiendo
	// texto por el final a la variable "lista". Observa el resultado
	// de la ejecucion en el log.
	
	/*

	void Start () {	
		
		int contador = 1;
		string lista = "";
		while(contador<=10){
			lista += "["+contador+"]";
			Debug.Log("Paso: " + (contador++));
		}
		Debug.Log(lista);
	}
	
	*/
	
}
