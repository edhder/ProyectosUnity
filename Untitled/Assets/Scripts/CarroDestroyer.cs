using UnityEngine;
using System.Collections;

public class CarroDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Carro") {
			Destroy (col.gameObject);//ESTAS 3 LINEAS DE COIGO NOS DICEN QUE CUANTO UN AUTO LLEGUE AL GAMEOBJECT SE AUTODESTRUIRA   
		}
	}
}
