using UnityEngine;
using System.Collections;

public class T11 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		// SWITCH
		
		int tipoObjetoTocado = 2;	// 0 -> moneda y da vidas, 1 -> Enemigo y quita vidas, 2 -> corazon y da vidas
		int vidas = 5;
		
		switch(tipoObjetoTocado){
			case 0:
			case 2:
				Debug.Log("Has ganado una vida");
				vidas++;
				break;
			case 1:
				Debug.Log("Has perdido una vida");
				vidas--;
				break;			
			default:
				Debug.Log("Tipo de objeto no reconocido");
				break;				
		}
	}
}
