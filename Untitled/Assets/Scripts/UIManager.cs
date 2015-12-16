using UnityEngine;
using System.Collections;
using UnityEngine.UI;//aqui importo funciones UI de unity 

public class UIManager : MonoBehaviour {

	public Button[] buttons;
	public Text scoreText;//aqui se almacenara el marcador 
	bool gameOver;//aqui se comprobara si ya choque el auto
	int score;//aqui se guardara el valor del marcador 

	// Use this for initialization
	void Start () {
		gameOver = false;//condicion booleana que inicia en falso y cuando sea asi el score va a ir incrementando y cuando sea true no se incrementara el score 
		score = 0;//aqui en el inicio del juego empieza en cero 
		InvokeRepeating ("scoreUpdate", 1.0f, 0.5f); //aqui se llama a la funcion scoreUpdate, despues se pone el tiempo que quiero que empieze a funcionar la funcion  y despues en cuanto tiempo se llamara la funcion de nuevo.
	}
	
	// Update is called once per frame
	void Update () { //funcion para incrementar el marcador
		scoreText.text = "Score: " + score; //aqui se adjunta el valor del scores
	}

	void scoreUpdate (){ //en esta funcion se ira incrementando en uno el marcador 

		if (gameOver == false) {// si en el juego no se ha perdido se incrementara el score
			score +=1;
		}
	}

	public void gameOverDetected(){

		gameOver = true;//cuando el auto choque se va a llamar esta funcion y como le puse true se cumpliria la condicion booleana y ya no se actualizaria el score 
		foreach (Button button in buttons) {//aqui se llama a cada boton foreach es como un for pero es mas eficiente usarlo en un array 
			button.gameObject.SetActive (true); //aqui se activan los botones 
		}
	}

	public void Play(){//funcion para dirigirme al primer nivel

		Application.LoadLevel ("Nivel1");//aqui se lee mi primer nivel
	}
	public void Pause(){

		if (Time.timeScale==1){//esta linea detecta cuando el juego esta corriendo
			Time.timeScale=0;//una vez detectado eso se podra poner pausa al juego
			
		}
		
		else if (Time.deltaTime == 0){ // cuando el juego este pausado 
			Time.timeScale =1;
		}
	} 

	public void Nivel2 () {
		Application.LoadLevel ("Nivel2");//Me lleva al segundo nivel 
	}

	public void Menu () {
		Application.LoadLevel ("Menu");//Me lleva al menu 
	}
	
}
