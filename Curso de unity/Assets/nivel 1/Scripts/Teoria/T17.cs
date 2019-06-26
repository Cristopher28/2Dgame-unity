using UnityEngine;
using System.Collections;

public class T17 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		// PASO DE PARAMETROS
	
		Contar(1, 5, "Contar del 1 al 5");
		Contar(9, 10, "Contar del 9 al 10");
		Contar(13, 15, "Contar del 13 al 15");
	}
	
	void Contar(int inicio, int fin, string titulo){
		Debug.Log(titulo);
		for(int c=inicio; c<=fin; c++){
			Debug.Log(c);
		}
	}

}
