using UnityEngine;
using System.Collections;

// ¡AVISO! No mires la solucion antes de intentar resolverlo por ti mismo.
// Si no, este curso no tendra tanto efecto como deberia.
// Los ejercicios sin hacer estan en la carpeta "Ejercicios". :)

public class E13Resuelto : MonoBehaviour {
	
	// Ejercicios capitulo 13. Bucles FOR.
	
	// Ejercicio 1. Mostrando numeros.
	// Sigue las instrucciones paso a paso dentro de "Start".

	/*

	void Start () {
		
		// 1a. Usando el bucle "for", haz que se muestren todos los
		// numeros desde el 1 hasta el 20:
		for(int c=2 ; c<=20 ; c+=2){
			Debug.Log(c);
		}
		
		// 1b. Haz que se ejecute este script y comprueba que la
		// salida del log es correcta. (Hay 20 logs, y muestran
		// consecutivamente los numeros del 1 al 20). Depura este
		// script paso a paso y observa las lineas que se van ejecutando
		// asi como las variables usadas.		
		
		// 1c. Añade una condicion al Debug.Log para que solo se ejecute
		// cuando el numero a sacar por log sea par:
		// Pista: Usa el operador modulo "%" para saber si el numero es par. 
		// (4%2==0) vale true (4 es par)
		// (5%2==0) vale false (5 NO es par)
		// (6%2==0) vale true (6 es par)
		// ...
		
		
		// 1d. Haz que se ejecute este script y comprueba que salen
		// exactamente 10 lineas de log, mostrando consecutivamente los
		// numeros pares del 2 al 20: 2, 4, 6, 8, 10, 12, 14, 16, 18, 20.
		// Aprovecha tambien para despues depurar paso a paso observando
		// que lineas se van ejecutando, intentando preveer que hara Unity
		// antes de avanzar al siguiente paso. Tambien observa el valor de
		// las variables en cada momento.
		
		// 1e. Deshaz los cambios hechos en el paso 1d: Elimina el "if" para
		// que el Debug.Log se ejecute siempre. Luego modifica el bucle "for"
		// hecho en el paso 1a para que recorra solo los numeros pares:
		// Pista: Es tan simple como inicializar la variable contador a 2, y
		// luego a la hora de incrementarla, en vez de hacerlo en uno, hacerlo
		// en dos. Asi el bucle recorrera los valores: 2, 4, 6, 8, 10, ... ,18 y 20.
		
		// 1f. Haz que se ejecute el codigo anterior y comprueba que tienes el mismo
		// resultado que en el paso 1d. Aprovecha para depurar y observar como va
		// cambiando el valor de la variable contador que vas incrementando de dos en dos.
		
	}
	
	*/
			
	// Ejercicio 2. Inicializando un array con un bucle for.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*
	
	void Start () {
		
		// 2a. Define un array de 10 numeros enteros llamado "numeros".
		// Modo elegante: new int[10];
		// Modo cutre: {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
		// Siempre es preferible usar el primer modo, ya que se escribe menos.
		int[] numeros = new int[10];
		
		// 2b. Usando un bucle "for" y una variable "cont" para contar las
		// vueltas, mete (uno a uno) en el vector (array) anterior los numeros
		// desde el 1 al 10, de forma que el array final tenga el contenido:
		// 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
		for(int cont = 0; cont < numeros.Length ; cont++){
			numeros[cont] = cont + 1;
		}
		
		// 1c. Usando un bucle "for", recorre todos los elementos del
		// array "numeros" y ve sacandolos por log.
		for(int cont = 0; cont < numeros.Length; cont++){
			Debug.Log(numeros[cont]);
		}
		
			
		// 1d. Haz que se ejecute este script y observa que de resultado
		// tienes 10 mensajes de log con los numeros del 1 al 10. Aprovecha
		// y tambien depura paso a paso para ver como se ejecuta y los
		// valores de las variables en cada momento.	
	}
	
	*/
	
	// Ejercicio 3. Calcular la media.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	// NOTA: La media es el resultado de dividir la suma de todos los 
	// valores entre el numero de valores que se ha sumado.
	// Ejemplo: La media de {5, 10, 3, 2} es 5. (5+10+3+2)/4 = 5
	
	/*

	void Start () {
		
		// 3a. Define un array de enteros llamado "valores" inicializandolo
		// con los siguientes valores: 2, 50, 45, 30, 55, 43
		int[] valores = {2, 50, 45, 30, 55, 43};
		
		// 3b. Define una variable entera "suma" para almacenar la suma de todos 
		// los valores inicializandola a cero:
		int suma = 0;
		
		// 3c. Usando un bucle "for" recorre todos los elementos del array "valores"
		// y ve incrementando la variable "suma" con el valor de "valores" en la vuelta
		// en la que estes en el bucle: (Usa la variable "cont" como contador para las
		// vueltas. Inicializandolo a 0. Ya que la primera posicion de un array es la 0)
		for(int cont = 0; cont < valores.Length; cont++){
			suma += valores[cont];
		}
		
		// 3d. Calcula el valor de la media y sacala por log de la forma:
		// Media obtenida: X
		// Siento X el valor de la media obtenida.
		int media = suma / valores.Length;
		Debug.Log("Media obtenida: "+media);
		
		// 3e. Haz que se ejecute este script y comprueba que el valor que obtienes
		// de calcular la media es 37. Haz que se ejecute otra vez depurando este
		// script paso a paso observando las lineas que se van ejecutando y los
		// valores de las variables en cada momento.
		
	}
	
	*/
	
	// Ejercicio 4. Energia de enemigos.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 4a. Define un vector de valores enteros llamado "energiaEnemigos"
		// inicializandolo a los siguientes valores:
		// 100, 5, 0, 20, 8, 74, 0, 1, 0, 43
		int[] energiaEnemigos = {100, 5, 0, 20, 8, 74, 0, 1, 0, 43};
		
		// 4b. Define una variable entera llamada "enemigosVivos" inicializandola
		// a cero.
		int enemigosVivos = 0;
		
		// 4c. Recorre el vector "energiaEnemigos" usando un bucle "for" y
		// cuenta en "enemigosVivos" cuantos enemigos siguen vivos:
		// (Los enemigos vivos tienen una energia mayor que cero)
		for(int c = 0; c < energiaEnemigos.Length; c++){
			if(energiaEnemigos[c]>0){
				enemigosVivos++;
			}
		}
		
		// 4d. Saca por log el numero de enemigos vivos de la forma:
		// Enemigos vivos: X
		// Siendo X el numero de enemigos vivos obtenido.
		Debug.Log("Enemigos vivos: "+enemigosVivos);
		
		// 4e. Haz que se ejecute este script y comprueba que el numero que
		// obtienes es 7. Tambien depura paso a paso, observando que linea se
		// va a ejecutar en cada paso y que valores de que variables cambiaran
		// en cada momento.
	}
	
	*/
	
	// Ejercicio 5. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 9 errores!
	
	/*

	void Start () {	
		
		int[] valores = {4, 9, 4, 2, 8, 7, 5};
		
		int suma = 0;		
		for(int c=0; c < valores.Length ; c++){
			suma+=valores[c];
		}
		
		Debug.Log("Suma de todos los valores: "+suma);
	}

	*/
	
}
