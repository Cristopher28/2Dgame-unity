using UnityEngine;
using System.Collections;

public class T13 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		/*
		int contador = 1;			// Inicializacion
		while(contador <= 10){		// Condicion
			Debug.Log(contador);	// Instrucciones del bucle
			
			contador++;				// Operaciones finales de cada vuelta
		}
		*/
	
		// FOR
		// for( inicializacion ; condicion ; Operaciones finales ){
		// Instrucciones del bucle
		//}
		
		for( int contadorFor = 1, a=0, b=0, c=0; contadorFor <= 10; contadorFor++,a--,b*=2,c+=3 ){
			Debug.Log(contadorFor);
			//int pepe = 100;
			//Debug.Log(pepe);
		}		

		Debug.Log("Terminado!");
		
	}

}
