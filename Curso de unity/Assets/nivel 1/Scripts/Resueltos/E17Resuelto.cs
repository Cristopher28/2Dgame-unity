using UnityEngine;
using System.Collections;

// ¡AVISO! No mires la solucion antes de intentar resolverlo por ti mismo.
// Si no, este curso no tendra tanto efecto como deberia.
// Los ejercicios sin hacer estan en la carpeta "Ejercicios". :)

public class E17Resuelto : MonoBehaviour {
	
	// Ejercicios capitulo 17. Metodos. Paso de parametros.
	
	// Ejercicio 1. Metodo sumar.
	// Sigue las siguientes instrucciones paso a paso.
	
	/*
	
	// 1a. Define un metodo llamado "MostrarSuma" que reciba dos
	// parametros enteros llamados "a" y "b", y lo que haga sea
	// sacar por log la suma de "a" y "b" de la siguiente forma:
	// A + B = C
	// Siendo A el valor que tenga "a", B el valor que tenga "b"
	// y C el valor del resultado de sumar "a" y "b".
	
	void MostrarSuma(int a, int b){
		Debug.Log(a+" + "+b+" = "+(a+b));
	}
	
	void Start () {
		
		// 1b. Haz una llamada al metodo "MostrarSuma" con los
		// valores: 5 y 5.
		MostrarSuma(5, 5);
		
		// 1c. Haz una llamada al metodo "MostrarSuma" con los
		// valores: 3 y 2.
		MostrarSuma(3, 2);
		
		// 1d. Haz que se ejecute este script y comprueba que en
		// el log obtienes este resultado:
		// 5 + 5 = 10
		// 3 + 2 = 5
		
		// 1e. Aprovecha para depurar paso a paso. Haz uso
		// del boton "Step Into" cuando estes situado en la linea
		// del metodo "MostrarSuma" para entrar a depurar paso a paso
		// el codigo de ese metodo. Observa paso a paso la ejecucion
		// y el valor de los parametros dentro del metodo.
		
	}	
	
	*/
	
	// Ejercicio 2. Saluda a...
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las siguientes instrucciones paso a paso.
	
	/*
	
	// 2a. Define un metodo "Saludar" que acepte un parametro llamado
	// "nombre" de tipo cadena de texto y otro llamado "cantidad"
	// de tipo entero, y que lo que haga sea sacar por log el siguiente 
	// texto tantas veces como indique el valor de "cantidad":
	// Hola X!
	// En la posicion de la X debera aparecer el nombre recibido en
	// el parametro "nombre".
	void Saludar(string nombre, int cantidad){
		if(cantidad>=1 && cantidad<=5){
			for(int c=1; c<=cantidad; c++){
				Debug.Log("Hola "+nombre+"!");
			}
		}else{
			Debug.Log("El valor del parametro 'cantidad' debe estar entre 1 y 5.");
		}
	}
	
	void Start () {
		
		// 2b. Haz una llamada al metodo "Saludar" para que salude
		// a "Maria" una sola vez:
		Saludar("Maria", 1);
		
		// 2c. Haz una llamada al metodo "Saludar" para que salude
		// a "Antonio" tres veces:
		Saludar("Antonio", 3);
		
		// 2d. Haz que se ejecute este script y comprueba que tienes
		// en el log la siguiente salida:
		// Hola Maria!
		// Hola Antonio!
		// Hola Antonio!
		// Hola Antonio!
		
		// 2e. Depura el codigo anterior observando (una vez haces
		// "Step Into" al metodo "Saludar") el contenido de los
		// parametros "nombre" y "contador".
		
		// 2f. Modifica el metodo "Saludar" para que solo muestre el
		// saludo si el parametro "cantidad" esta entre 1 y 5 
		// (incluidos el 1 y el 5). Si no, en vez de sacar el saludo 
		// por log, debera sacar el mensaje: 
		// "El valor del parametro 'cantidad' debe estar entre 1 y 5."
		
		// 2g. Haz una llamada al metodo "Saludar" para que salude
		// a "Lucas" 6 veces:
		Saludar("Lucas", 6);
		
		// 2h. Haz que se ejecute este script y comprueba que tienes en
		// el log la siguiente salida:
		// Hola Maria!
		// Hola Antonio!
		// Hola Antonio!
		// Hola Antonio!
		// El valor del parametro 'cantidad' debe estar entre 1 y 5.
	}
	
	*/
	
	// Ejercicio 3. Llamadas a metodos dentro de metodos.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Sigue las siguientes instrucciones paso a paso.
	
	/*
	
	// 3a. Define un metodo llamado "MostrarMensaje" que reciba como
	// parametro una cadena de texto llamada "mensaje" y la saque por
	// log:
	void MostrarMensaje(string mensaje){
		Debug.Log(mensaje);
	}
	
	// 3b. Define un metodo llamado "RepetirMensaje" que reciba como
	// parametro una cadena de texto llamada "mensaje" y un valor
	// entero llamado "cantidad" que contenga el numero de veces que
	// se va a mostrar "mensaje":
	// NOTA: En vez de llamar a Debug.Log, llama al metodo que
	// mostraba un mensaje que creaste en el paso anterior.
	// Si no, este ejercicio no se llamaria "Llamadas a metodos
	// dentro de metodos".
	void RepetirMensaje(string mensaje, int cantidad){
		for(int c=1; c<=cantidad; c++){
			MostrarMensaje(mensaje);
		}
	}

	void Start () {
		
		// 3c. Haz una llamada al metodo "RepetirMensaje" para que
		// se muestre el mensaje "Hola mundo!" 5 veces:
		RepetirMensaje("Hola mundo!", 5);
		
		// 3d. Haz que se ejecute este script y comprueba que la salida
		// del log es: (5 lineas "Hola mundo!")
		// Hola mundo!
		// Hola mundo!
		// Hola mundo!
		// Hola mundo!
		// Hola mundo!		
		
		// 3e. Depura el codigo anterior paso a paso, usando el boton
		// "Step Into" cuando estes situado en una linea que llama a
		// un metodo que tu hayas creado (RepetirMensaje y MostrarMensaje)
		// para las demas lineas, usa "Step Over". Observa el valor de las
		// variables en todo momento.
	}
	
	*/
	
	// Ejercicio 4. Solucion de los errores mas comunes.
	// Comenta el bloque anterior y descomenta el bloque siguiente.
	// Corrige todos los errores que se muestren en la consola.
	// PISTA: Hay 5 errores!
	
	/*

	// Metodo que recibe una cadena de texto para mostrar
	void MostrarMensaje(string mensaje){
		Debug.Log(mensaje);
	}

	void Start () {	
		
		int cont = 1;
		do{
			MostrarMensaje(""+cont);
			cont++;
		}while(cont<=10);
	}
	
	*/
	
}
