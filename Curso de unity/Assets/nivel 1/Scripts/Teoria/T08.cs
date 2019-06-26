using UnityEngine;
using System.Collections;

public class T08 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	/*
		// 1. Operadores logicos
		// ========================
		bool esDeDia = true;
		bool soyProgramador = true;
		bool tengoHambre = false;
		
		// Operador AND (&&) "Y"
		// Devolvera true SI y SOLO SI los dos valores que tiene son true.
		// true && true => true
		// true && false => false
		// false && true => false
		// false && false => false
		Debug.Log(soyProgramador && esDeDia);
		
		// Operador OR (||) "O"
		// Devolvera true si alguno de los valores que tiene al lado vale verdadero
		// true || true => true
		// true || false => true
		// false || true => true
		// false || false => false
		bool res = esDeDia || tengoHambre;
		Debug.Log(res);
		
		// Operador NOT (!) "NO"
		// Invierte el valor logico
		// !true => false
		// !false => true
		// !!!true => false
		Debug.Log(!tengoHambre);
		
		// Operadores encadenados
		Debug.Log(!tengoHambre || (!esDeDia && soyProgramador));
		
		*/
		
		// 2. Operadores de comparacion
		// ============================
		// == (Es igual a)
		// != (Es distinto de)
		// Los siguientes solo para valores numericos: int y float
		// > (Mayor que)
		// >= (Mayor o igual)
		// < (Menor que)
		// <= (Menor o igual)
		
		/*
		Debug.Log( 5 == 5 );	// true
		Debug.Log("Hola" == "hola"); //false
		Debug.Log( false != false ); // false
		Debug.Log( false == (6 != 5) ); // false
		Debug.Log( 5 > 4 );	// true
		bool resultado = 1 >= 10;	// false
		Debug.Log(resultado);
		
		// Enlazar operaciones
		Debug.Log( (((6 > 3) == true) && (9<=9)) ); // true
		
		// Enlazar operaciones con variables
		string c1 = "Hola";
		string c2 = "Hola";
		Debug.Log(!(c1 == c2));	// false
		int a = 10;
		int b = 20;
		Debug.Log(a != 20);	// true
		*/
	}
	
}
