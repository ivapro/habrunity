using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerActions : MonoBehaviour {

	public GameObject player;
	public int speed;
	public int rotationSpeed;

	// Use this for initialization
	void Start () {
		player = (GameObject)this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			player.transform.position += transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {
			player.transform.position -= transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D)) {
			player.transform.Rotate (Vector3.up * rotationSpeed*Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			player.transform.Rotate (Vector3.down * rotationSpeed*Time.deltaTime);
		}
	}
	void OnGUI(){
		if (player.transform.position.z >= 0.99 && player.transform.position.z <= 1.75 &&  player.transform.position.x <= -1.1 && transform.position.x>=-1.49 ) {
			if (GUI.Button (new Rect (200, 200, 800, 400), "You are win!\nExit")) 
			{Application.Quit ();}
			Time.timeScale = 0;
		}
	}
}
