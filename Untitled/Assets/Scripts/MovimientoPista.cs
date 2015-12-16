using UnityEngine;
using System.Collections;

public class MovimientoPista : MonoBehaviour {
	
	public float speed;//aqui se va a controlar la velocidad en la que la pista se esta moviendo, se puede ver en el inspector
	Vector2 offset;//aqui se va a repetir la textura o sea la pista una y otra vez como un loop hasta que se termine el juego
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		offset = new Vector2 (5,Time.time * speed);//incrementa el valor dependiendo del tiempo /* dependiendo del tiempo el valor va a incrementar y dependiendo
		//de la velocidad se va a ir aumentando la velocidad de la pista al ir avancando el fierrari, el 0 es porque no se va a mover en X y si en Y
		GetComponent<Renderer>().material.mainTextureOffset = offset;//esta linea nos va a dar un renderer, despues accede al material del mencionado renderer
		//y de ahi obtiene la textura principal fuera del set y pone el offset dentro de el como valor, CON ESO SE LOGRA QUE LA PISTA ESTE EN CONSTANTE MOVIMIENTO
	}
}
