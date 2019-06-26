using UnityEngine;
using System.Collections;

// ¡AVISO! No mires la solucion antes de intentar resolverlo por ti mismo.
// Si no, este curso no tendra tanto efecto como deberia.
// Los ejercicios sin hacer estan en la carpeta "Ejercicios". :)

public class E10Resuelto : MonoBehaviour {
	
	// Ejercicios capitulo 10. Condicional IF.
	
	// Ejercicio 1. Condicional simple.
	// Sigue las instrucciones paso a paso dentro de "Start".
	
	/*
	
	void Start () {
		
		// 1a. Define una variable entera llamada "puntuacion" inicializandola a 100:
		int puntuacion = 99;
		
		// 1b. Define una variable logica llamada "ganaUnaVida" y que valga el
		// resultado de evaluar si el valor de "puntuacion" es mayor o igual que 100:
		bool ganaUnaVida = puntuacion >= 100;
		
		// 1c. Usa el condicional "if" para que muestre por log el mensaje 
		// "Has ganado una vida!" dependiendo del valor de la variable "ganaUnaVida":
		if(ganaUnaVida){
			Debug.Log("Has ganado una vida!");
		}
		
		// 1d. Adivina si aparecera algun mensaje segun el codigo anterior. Luego
		// haz que se ejecute este script y comprueba si estabas en lo cierto.
		// Vuelvelo a depurar paso a paso viendo que linea se ejecuta en cada momento.
		
		// 1e. Cambia el valor de inicializacion de "puntuacion" al valor 99 y vuelve
		// a depurar el codigo deteniendote en el "if", observando el valor de "ganaUnaVida"
		// y comprobando que al ser falso, no se ejecutara la linea Debug.Log que muestra
		// el mensaje.
	}
	
	*/
	
	// Ejercicio 2. if/else
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 2a. Define una variable entera "puntos" inicializandola con el valor 0:
		int puntos = 0;
		
		// 2b. Define una variable logica "doblePuntuacion" inicializandola a false:
		bool doblePuntuacion = false;
		
		// 2c. Si "doblePuntuacion", entonces incrementa en 2 unidades "puntos";
		// si no, incrementala en 1:
		if(doblePuntuacion){
			puntos += 2; // puntos = puntos + 2;
		}else{
			puntos++;	// puntos += 1;	// puntos = puntos + 1
		}
		
		// 2d. Saca por log el contenido de "puntos":
		Debug.Log(puntos);
		
		// 2e. Haz que se ejecute este script y observa el valor que obtenemos por
		// log cuando "doblePuntuacion" se inicializa a false y a true. Depura paso
		// a paso alguno de estos casos observando que lineas se ejecutan y el valor
		// de las variables en cada momento.
		
	}
	
	*/
	
	// Ejercicio 3. if/else encadenados
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 3a. Define una variable entera "edad" con el valor 10:
		int edad = 19;
		
		// 3b. Si "edad" es mayor o igual a 60, saca por log el texto
		// "Se te considera un anciano". Si no, comprueba si "edad" es
		// mayor o igual a 18. Si lo es, saca por log "Se te considera adulto",
		// Si no, saca por log "Se te considera joven":
		if(edad >= 60){
			Debug.Log("Se te considera un anciano");
		}else if(edad >= 18){
			Debug.Log("Se te considera adulto");
		}else{
			Debug.Log("Se te considera joven");
		}
		
		// 3c. Depura este script paso a paso observando en cada momento las variables
		// y las lineas que se ejecutan. Prueba tambien inicializando la variable 
		// "edad" a 19 y 65.
	}
	
	*/
	
	// Ejercicio 4. if/else con varias lineas de codigo
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 4a. Define una variable entera "vidas" con el valor 3:
		int vidas = 3;
		
		// 4b. Define una variable entera "monedas" con el valor 101:
		int monedas = 99;
		
		// 4c. Si "monedas" es mayor o igual que 100, haz todo lo siguiente:
		// restale 100 a la variable "monedas". Luego  haz que la variable
		// "vidas" se incremente en uno y se muestre por log el mensaje 
		// "Has ganado una vida! Ahora tienes X vidas". (Y que en vez de
		// esa "X" en el mensaje, aparezca el valor de la variable "vidas":
		if(monedas>=100){
			monedas-=100;
			vidas++;
			Debug.Log("Has ganado una vida! Ahora tienes "+vidas+" vidas");
		}
		
		// 4d. Depura paso a paso viendo las lineas que se ejecutan y
		// observando los valores de las variables usadas, asi como ver
		// el resultado final en el log. Vuelve a hacer lo mismo inicializando
		// la variable "monedas" esta vez a 99.
	}
	
	*/
	
	
	// Ejercicio 5. if/else con varias lineas de codigo
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 5a. Define una variable "A" de tipo array de enteros
		// inicializada a los valores 1, 2, 3:
		int[] A = {1, 2, 3};
		
		// 5b. Define una variable "B" de tipo array de enteros
		// inicializandola a los valores 2, 3, 4:
		int[] B = {2, 3, 4};
		
		// 5c. Saca por log "La suma de los elementos de A es par"
		// si la suma de los tres elementos de "a" es par. Si no,
		// saca por log "La suma de los elementos de A es impar":
		// Pista: 	4%2=0	5%2=1	6%2=0	7%2=1	8%2=0
		
		//if((A[0]+A[1]+A[2])%2 == 0){
		//	Debug.Log("La suma de los elementos de A es par");
		//}else{
		//	Debug.Log("La suma de los elementos de A es impar");
		//}
		
		Debug.Log(((A[0]+A[1]+A[2])%2 == 0) ? "La suma de los elementos de A es par" : "La suma de los elementos de A es impar");
		
		// 5d. Haz lo mismo con "B":
		
		//if((B[0]+B[1]+B[2])%2 == 0){
		//	Debug.Log("La suma de los elementos de B es par");
		//}else{
		//	Debug.Log("La suma de los elementos de B es impar");
		//}
		
		Debug.Log(((B[0]+B[1]+B[2])%2 == 0) ? "La suma de los elementos de B es par" : "La suma de los elementos de B es impar");
		
		// 5e. Mira el codigo y averigua que saldra por log. Luego
		// haz que se ejecute este script para comprobarlo.
		
		// 5f. Modifica el codigo del paso 5c y 5d para obtener
		// el mismo resultado utilizando el operador ternario "?:".
		
		// 5g. Haz que se ejecute este script de nuevo para comprobar
		// que funciona como se esperaba.
	}
	
	*/		
	
	// Ejercicio 6. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 8 errores!
	
	/*

	void Start () {	
		
		// Elegimos un numero aleatorio entre 0 y 1, dependiendo del
		// numero obtenido sacamos el texto "Cara!" o "Cruz!".
		if(Random.Range(0,2)==0){
			Debug.Log("Cara!");
			int valor = 0;
			Debug.Log(valor);
		}else{
			Debug.Log("Cruz!");
			int valor = 1;
			Debug.Log(valor);
		}
		
		//Debug.Log(valor);
	}
	
	*/	
	
}
