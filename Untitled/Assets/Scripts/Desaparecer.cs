using UnityEngine;
using System.Collections;

public class Desaparecer : MonoBehaviour {
	
	int carNo;
	public GameObject [] cars;//este va a ser el carro que se va a instanciar 
	public float maxPos = 2.1f;//aqui se le pondra un limite a los autos que aoarezcan para que se ven en la autopista 
	public float delayTimer = 1f; //aqui voy a pner un valor para que mi variable timer tenga un delay 
	float timer;//este timer va a almacenar el valor del rango donde se va a mover 
	// Use this for initialization
	void Start () {
		timer = delayTimer;//aqui al timer ya le estoy asignando el valor de 1f
		
	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;//esta linea me sirve para decrementar en cada frame el valor del timer hasta que llegue a 0 
		
		if (timer <= 0) {
			
			Vector3 carPos = new Vector3(Random.Range(-2.26f, 2.32f), transform.position.y,transform.position.z);//aqui se limita el rango de posicion x para que aparezca el auto tipo random en su carril 
			carNo = Random.Range (0,6);//se cuenta de 0 a 7 mis carros 
			Instantiate (cars [carNo], carPos , transform.rotation);//aqui se esta instanciando el objeto car y las posiciones en donde va a aparecer  
			timer = delayTimer; //aqui le asigno de nuevo el valor de 1f para que vuelva a decrementar el valor hasta 0, un loop 
			
		}
	}
}

