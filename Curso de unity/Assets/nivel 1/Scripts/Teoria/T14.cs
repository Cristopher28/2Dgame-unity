using UnityEngine;
using System.Collections;

public class T14 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		int[] valores = {1, 3, 5, 7, 9, 11};
		
		// Recorrer un array con un bucle for
		/*
		for(int c = 0; c < valores.Length; c++){
			Debug.Log(valores[c]);
		}
		*/
	
		// FOREACH
		
		foreach(int valor in valores){
			Debug.Log(valor);
		}

	}

}
