using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {


	// Destroy Trigger Object

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("Obstacle") || collider.CompareTag("Collectables")){
			Destroy (collider.gameObject);
		}
	}

}
