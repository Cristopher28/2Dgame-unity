using UnityEngine;
using System.Collections;

// ¡AVISO! No mires la solucion antes de intentar resolverlo por ti mismo.
// Si no, este curso no tendra tanto efecto como deberia.
// Los ejercicios sin hacer estan en la carpeta "Ejercicios". :)

public class E18Resuelto : MonoBehaviour {
	
	// Ejercicios capitulo 18. Metodos. RETURN.
	
	// Ejercicio 1. Metodo que suma
	// Sigue las siguientes instrucciones paso a paso.
	
	/*
	
	// 1a. Define un metodo llamado "Suma" que reciba dos parametros
	// de tipo valor entero llamados "a" y "b", y que devuelva el
	// resultado de sumar estos dos parametros.
	int Suma(int a, int b){
		//int c = a + b;
		//return c;
		return a + b;
	}
	
	void Start () {
		
		// 1b. Haz una llamada al metodo "Suma" con los valores 1 y 2 y
		// recoge su resultado en una variable de tipo entero llamada
		// "resultado":
		int resultado = Suma(1, 2);
		
		// 1c. Saca por log el valor de "resultado":
		Debug.Log(resultado);
		
		// 1d. Haz que se ejecute este script y comprueba que el resultado
		// que obtienes por log es: 3		
		
		// 1e. Pon un punto de ruptura en la linea de Debug.Log y depura
		// paso a paso para ver el contenido de la variable "resultado"
		// antes de hacer que salga por log.
		
	}
	
	*/
	
	// Ejercicio 2. Buscando el numero mas grande en un array...
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las siguientes instrucciones paso a paso.
	
	/*
	
	// 2a. Define un metodo llamado "ElementoMasGrande" que reciba como
	// parametro un array de enteros y devuelva el valor del elemento 
	// mas grande de los que hay en el array.
	// Pista: Recorre el array desde el primer elemento hasta el ultimo
	// teniendo siempre en una variable el elemento mas grande encontrado
	// y actualizandola en caso de encontrar uno mas grande:
	int ElementoMasGrande(int[] array){
		int masGrande = 0;
		foreach(int elemento in array){
			if(elemento > masGrande){
				masGrande = elemento;
			}
		}
		return masGrande;
	}

	void Start () {
		
		// 2b. Define un array de enteros llamado "valores" con los valores:
		// 4, 6, 1, 9, 2, 3, 2, 5, 9, 8
		int[] valores = {4, 6, 1, 9, 2, 3, 2, 5, 9, 8};
		
		// 2c. Define una variable entera llamada "maximo" inicializandola al
		// valor obtenido de llamar al metodo "ElementoMasGrande" pasandole
		// como parametro el array "valores":
		int maximo = ElementoMasGrande(valores);
		
		// 2d. Saca por log el valor de "maximo":
		Debug.Log(maximo);
		
		// 2e. Haz que se ejecute este script y comprueba que el valor que sale
		// por log es el valor: 9		
		
		// 2f. Depura paso a paso el codigo anterior observando como funciona
		// el bucle que busca el valor maximo de todos los del array.
		
	}
	
	*/
	
	// Ejercicio 3. Fuera de pantalla.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las siguientes instrucciones paso a paso.
	
	/*
	
	// 3a. Define un metodo llamado "FueraDePantalla" que recibe un parametro de
	// tipo real (float) llamado "posicionX" y devuelve si esta fuera de la pantalla 
	// en base al parametro recibido. (Devuelve un valor logico)
	// Si posicionX es mayor o igual a cero y menor o igual a 100, entonces
	// estamos dentro de la pantalla. Si no, estamos fuera de la pantalla:
	bool FueraDePantalla(float posicionX){
		bool resultado = posicionX < 0 || posicionX > 100;
		return resultado;
	}

	void Start () {
		
		// 3b. Define una variable real (float) con el nombre "x" inicializada a 23:
		float x = 123f;
		
		// 3c. Usando la funcion (usando "x" como parametros) que nos dice si el valor esta 
		// fuera de la pantalla hacer un condicional que muestre en el log: "Estas dentro de 
		// la pantala." si estamos dentro, y "Estas fuera de la pantalla. Game Over!" si estamos fuera:
		if(FueraDePantalla(x)){
			// estamos fuera...
			Debug.Log("Estas fuera de la pantalla. Game Over!");
		}else{
			// estamos dentro...
			Debug.Log("Estas dentro de la pantala.");
		}
		
		// 3d. Haz que se ejecute este codigo y comprueba que obtienes por log el
		// mensaje de que estamos dentro de la pantalla.
		
		// 3e. Depura paso a paso el codigo anterior pasando por todas las instrucciones
		// y entrando a depurar el codigo del metodo "FueraDePantalla".
		
		// 3f. Inicializa la variable "x" a un valor que nos de como resultado la salida
		// por log de que estamos fuera de la pantalla. Haz que se ejecute el script y
		// comprueba que tenemos la salida esperada.
		
	}
	
	*/	
	
	// Ejercicio 5. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 3 errores!
	
	/*
	
	int Mayor(int a, int b){
		int resultado = (a > b) ? a : b;
		return resultado;
	}

	void Start () {			
		int a = 35, b = 99;
		int mayor = Mayor (a, b);
		Debug.Log(mayor + " es el mas grande de " + a + " y " + b);
	}
	
	*/
	
}
