using UnityEngine;
using System.Collections;

public class T16 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		// METODOS (o FUNCIONES)
		
		ContarNumeros();
		
		// HAY MAS CODIGO
		// ...
		// (500 lineas mas)
		// ...
		
		ContarNumeros();
		
		// HAY MAS CODIGO
		// ...
		// (1500 lineas mas)
		// ...
		
		ContarNumeros();
	
	}
	
	void ContarNumeros(){
		Debug.Log("Hola. Voy a contar del 1 al 10.");
		for(int c=1; c<=10; c++){
			Debug.Log(c);
		}
		Debug.Log("Terminado!");
	}

}
