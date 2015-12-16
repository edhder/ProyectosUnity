
using UnityEngine;
using System.Collections;

public class MovimientoAuto : MonoBehaviour {
	
	public float AutoMovimiento;//variable automovimiento que me permitira controlar la velicidad del carro 
	public float Restriccionpista = 2.07091f;//valor que tiene el auto cuando se acerca al borde de la salida de la pista
	
	Vector3 position; //otra variable Vector3 que tiene la posicion temporal del carro
	public UIManager ui;//esto sirve parra instanciar el script UIManager  
	

	// Use this for initialization
	void Start () {
		//ui = GetComponent <UIManager> ();//esta linea nos permite el acceso al script
		position = transform.position;//aqui se va a transformar la posicion dentro de position, transform.position tiene la actual posicion del auto
		
	}
	
	// Update is called once per frame
	void Update () {
		
		position.x += Input.GetAxis ("Horizontal") * AutoMovimiento * Time.deltaTime;//aqui se va a incrementar el valor de la posicion dependiendo de cuanto mueva las felchas derecha o izquierda(Horizontal)
		
		position.x = Mathf.Clamp (position.x, -2.07091f, 2.07091f); //funcion que nos da unity, limita el valor de la variable, -2.07091 es el minimo valor del otro lado de la pista
		//clamp regresa el valor delimitado entre el - y el + 2.07091
		transform.position = position;
	}
	
	void OnCollisionEnter2D(Collision2D col){//esta funcion que da unity sirve para detectar alguna colision con cualquier otro colider 
		if (col.gameObject.tag == "Carro") {//si se detecta que se choco con el colider Enemmy Car
			Destroy (gameObject);//se va a destruir mi gameobject osea mi auto 
			ui.gameOverDetected();//no se actualizara el marcador 

		}
	}
	
	
	
}

