using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	public float speed;

	private Rigidbody2D rigidBody;

	void Awake(){
		rigidBody = GetComponent<Rigidbody2D> ();
		rigidBody.velocity = new Vector2 (0, -speed);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Destroy Player When Hit

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("Player")){
			GameplayController.instance.PlayerDied (collider.gameObject);
		}
	}

}
