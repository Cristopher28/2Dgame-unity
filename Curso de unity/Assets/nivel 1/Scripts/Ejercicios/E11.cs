using UnityEngine;
using System.Collections;

public class E11 : MonoBehaviour {
	
	// Ejercicios capitulo 11. SWITCH
	
	// Ejercicio 1. Vidas y monedas.
	// Sigue las instrucciones paso a paso dentro de "Start".
	
	void Start () {
		
		// 1a. Define una variable entera llamada "tipoObjetoTocado" con el valor 0:
		// Valores que puede tener la variable: 0 = Moneda; 1 = Enemigo; 2 = Item ganar vidas
		
		
		// 1b. Define una variable entera llamada "monedas" inicializada a 0:
		
		
		// 1c. Define una variable entera llamada "vidas" inicializada a 3:
		
		
		// 1d. Usando un "switch", si el tipo de objeto tocado es una moneda, incrementar
		// el numero de monedas en uno y sacar por log "Otra moneda mas!". Si es el item 
		// de ganar vidas, incrementa la vida en uno y saca por log "Ganaste una vida!".
		// Si es un enemigo, resta una vida y saca por log "Pierdes una vida!":
		
		
		// 1e. Depura paso a paso este script observando en cada momento que lineas se van
		// ejecutando y el contenido de todas las variables, asi como el resultado que sale
		// al final en el log. Vuelve a depurar paso a paso inicializando "tipoObjetoTocado" a 1 y 2.
	}
	
	// Ejercicio 2. Tambien con cadenas de texto, valores logicos, numeros con decimales, etc.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 2a. Define una variable de texto "clave" inicializandola a "1234":
		// (La clave "1234" pertenecera a un usuario normal, la clave "3141" a
		// un usuario editor, y la clave "8007" a un usuario administrador)
		
		
		// 2b. Define un array "accesos" de tres elementos inicizado todo a 0:
		// (La primera posicion [0] sera el total de accesos del usuario normal,
		// la segunda [1] sera el total de accesos del usuario editor, y la
		// tercera [2] sera el total de accesos del usuario administrador) 
		
		
		// 2c. Usa switch para identificar segun la clave, que tipo de usuario
		// esta haciendo login. Luego en cada case, saca por log el mensaje adecuado:
		// "Usuario ha accedido", "Editor ha accedido" o "Administrador ha accedido".
		// Ademas de incrementar en uno el valor de la posicion del array al que
		// le corresponde a ese tipo de usuario.
		// En el caso de que "clave" no corresponda con ninguna de las tres que
		// hay definidas, que se muestre por log el texto: "Acceso no permitido!".
		// (Pista: Para este ultimo punto usa el "default", en vez de "case")
		
		
		// 2d. Saca por log el valor de cada acceso del array "accesos":
		// Que se vea tal que asi:
		// Accesos de usuarios: X
		// Accesos de editores: X
		// Accesos de administradores: X
		// (No muestres la X, la he puesto ahi para indicar que ahi tendra que aparecer
		// el valor que hay en la posicion adecuada del array)
		
		
		// 2e. Depura este script paso a paso observando que lineas se van ejecutando y
		// cual es el contenido de las variables en todo momento. Observa el resultado
		// final en el log. Repite este paso de nuevo, pero esta vez inicializando la variable 
		// "clave" a la clave del usuario editor, a la del usuario administrador, y a "8888".
		// (Mientras depuras paso a paso, intenta adivinar cual sera la siguiente linea que
		// se ejecutara y que hara esta)
	}
	
	*/
	
	// Ejercicio 3. Cases agrupados
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las instrucciones paso a paso dentro el mismo.
	
	/*

	void Start () {
		
		// 3a. Define una variable entera "vidas" inicializandola a 3:
		
		
		// 3b. Define una variable entera "puntos" incializandola a 0:
		
		
		// 3c. Define una variable entera "tipoObjeto" e inicializala con 0:
		// (Elementos que dan 10 puntos: Moneda = 0, Corazon = 1, Oro = 2
		// elementos que quitan una vida: Pinchos = 3, Bomba = 4)
		
		
		// 3d. Dependiendo del tipo de objeto que haya en "tipoObjeto"
		// haz que se sume 10 puntos a "puntos" o se reste una vida a "vidas":
		
		
		// 3e. Modifica el codigo del paso 3d para que, ademas de sumar 10 puntos
		// a "puntos", si "tipoObjeto" es Oro, saque solo en este caso el texto
		// "Has encontrado oro!".
		
		// 3f. Modifica el codigo del paso 3d para que si "tipoObjeto" 
		// tuviera cualquier otro valor, mostrar por log el texto 
		// "El tipo de objeto X no existe". En vez de una X, justo
		// en esa posicion debera mostrarse el numero que representa al
		// objeto que no existe.		
		
		// 3e. Muestra por log el contenido de "vidas" y "puntos":
		// Que se vea de esta forma:
		// Vidas: X
		// Puntos: X
		// (Las X deberan ser el valor de cada variable)
		
		
		// 3e. Depura este script, observando las lineas que se van ejecutando,
		// las variables, y lo que sale en el log una vez termina su ejecucion.
		// Prueba otra vez inicializando "tipoObjeto" con el numero 4 y con el 5.
	}
	
	*/	
	
	// Ejercicio 4. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 6 errores!
	
	/*

	void Start () {	
		
		int numeroLoteria == 43;
		
		switch(numeroLoteria)
			case 10;
				Debug.Log("Numero acertado!);
				break;
			case 22:
				Debug.Log("Numero acertado!");
			case 43:
				Debug.Log("Numero acertado!")
				break;
			default:
				Debug.Log("Lo siento, pero tu numero no esta entre los agraciados!");
				break;
		}
	}
	
	*/
	
}
