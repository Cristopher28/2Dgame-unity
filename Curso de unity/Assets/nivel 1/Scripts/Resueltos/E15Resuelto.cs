using UnityEngine;
using System.Collections;

// ¡AVISO! No mires la solucion antes de intentar resolverlo por ti mismo.
// Si no, este curso no tendra tanto efecto como deberia.
// Los ejercicios sin hacer estan en la carpeta "Ejercicios". :)

public class E15Resuelto : MonoBehaviour {
	
	// Ejercicios capitulo 15. BREAK y CONTINUE.
	
	// Ejercicio 1. Rompiendo el bucle.
	// Sigue las instrucciones paso a paso dentro de "Start".
	
	/*
	
	void Start () {

		// 1a. Haz un bucle "for" con una variable "cont" para
		// que esta vaya desde el 1 hasta el 20. Ambos incluidos.
		// Dentro del bucle, saca por log el contenido de la variable
		// "cont":
		for(int cont = 1; cont<=20; cont++){
			if(cont>5){
				break;
			}
			Debug.Log(cont);
		}
		
		// 1b. Haz que se ejecute este script y comprueba que salen
		// por log exactamente 20 lineas con los numeros del 1 al 20.
		
		// 1c. Dentro del bucle "for" del paso 1a y antes de que se saque
		// por log el valor de "cont", añade una linea nueva que haga
		// un "break" si se da la condicion de que "cont" es mayor que 5.
		
		// 1d. Haz que se ejecute este script y comprueba que salen
		// por log exactamente 5 lineas con los numeros del 1 al 5. Depura
		// paso a paso observando las lineas que se van ejecutando y el
		// contenido de las variables en todo momento. Presta especial
		// atencion a que ocurre una vez se ejecuta en el depurador la
		// orden "break": A que linea va la ejecucion despues.
		
		// 1e. Prueba a poner un punto de ruptura condicional en el "if"
		// para que la depuracion se pare justo en el momento de que esa 
		// condicion se va a cumplir y cumprueba que lo has hecho bien.
		// (Es decir, que se para en el "if" justo cuando la variable "cont" 
		// es mayor que 5)
		
	}
	
	*/
	
	// Ejercicio 2. Saltando elementos...
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 2a. Define un array de 10 valores enteros con el nombre "valores":
		// Pista: new int[10];
		int[] valores = new int[10];
		
		// 2b. Usando un bucle "for" rellena el array anterior con los numeros
		// del 1 al 10. El 1 en la posicion con indice 0, el 2 en la posicion con 
		// indice 1, etc.:
		
		// 1 -> [0]
		// 2 -> [1]
		// 3 -> [2]
		// ...
		for(int c=1; c<=10; c++){
			valores[c-1] = c;
		}
		
		// 2c. Usando un bucle "foreach" recorre todos los elementos del array
		// y saca su contenido por log:
		foreach(int valor in valores){
			if(valor%2==1){
				continue;
			}
			Debug.Log(valor);
		}
		
		// 2d. Haz que se ejecute este codigo y comprueba que por log
		// obtienes los 10 numeros. Del 1 al 10.
		
		// 2e. Modifica el bloque de codigo del apartado 2c usando un "continue" en
		// un condicional para que si el numero que tenemos en la iteracion actual es
		// impar, se pase a la iteracion siguiente sin mostrar ese numero impar por log.
		// Pista: Para comprobar que un numero es impar, solo tenemos que comprobar
		// si su resto de dividirlo con el numero 2, vale 1.
		// bool esCincoImpar = (5 % 2 == 1);
		
		// 2f. Haz que se ejecute este codigo y comprueba que por log salen
		// los numeros 2, 4, 6, 8, 10. Depura paso a paso este codigo observando las
		// lineas que se ejecutan y los valores de las variables en cada momento.
		// Presta especial atencion a que ocurre una vez se ejecuta "continue".
		// (A donde va la ejecucion del codigo)
		
	}
	
	*/
	
	// Ejercicio 3. Numeros primos.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.	
	
	/*

	void Start () {
		
		// 3a. Haz un codigo que muestre por log todos los numeros
		// primos que hay entre el 1 y el 100. Sacar un numero por
		// linea.
		// Un numero se considera primo si solo es divisible (tiene 
		// resto cero) por el mismo, y por el 1.
		// ¿Es 5 primo? Vemos que 5 NO es divisible entre 4 (no da
		// resto cero), NI entre 3, Ni entre 2. Asi que 5 es primo.
		// ¿Es 6 prmo? Vemos que 6 NO es divisible entre 5, NI entre
		// 4, PERO si entre 3: 6%3=0. Asi que 6 no es primo.
		// El numero 1 no se considera primo.
		// Mas info: http://es.wikipedia.org/wiki/N%C3%BAmero_primo
		for(int n=2; n<=100; n++){
			// Vamos a suponer que ese numero "n" es primo
			bool esPrimo = true;
			// Vamos a dividir ese numero entre todos los numeros inferiores al mismo.
			// Sin dividirlo entre el mismo y uno.
			for(int c=2; c<n; c++){
				if(n%c==0){
					esPrimo = false;
					break;
				}
			}
			if(esPrimo){
				Debug.Log(n);	
			}
		}
		
	}
	
	*/
	
	// Ejercicio 4. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 6 errores!
	
	/*

	void Start () {	
	
		int[] numeros = new int[100];
		for(int c=0; c<100; numeros[c++]=c);
		
		for(int c=0; c<100; c++)
		{
			if(numeros[c]%2==0 || numeros[c]%3==0) continue;
			if(c>=20) break;
			
			Debug.Log(numeros[c]+" no es divisible ni por 2, ni por 3.");
		}

	}
	
	*/
		
	
}
