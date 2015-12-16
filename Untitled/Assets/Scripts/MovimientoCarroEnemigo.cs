using UnityEngine;
using System.Collections;

public class MovimientoCarroEnemigo : MonoBehaviour {
	
	public float speed = 5f; //aqui se pone la velocidad con la que quiero que el aut se mueva
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3(-1,0,0) * speed * Time.deltaTime); //transform.translate permite direccionar el auto hacia una direccion en particluar, en el vector se pondra la direccion del auto, se tiene que multiplicar por la velocidad que quiero que mi carro se mueva 
	}
}

