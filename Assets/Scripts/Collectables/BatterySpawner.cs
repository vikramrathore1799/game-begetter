using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySpawner : MonoBehaviour {

	public GameObject battery;

	private float maxleft, maxRight, maxTop;
	private float time;
	private int delay;

	void Awake(){
		time = 0f;
		delay = Random.Range (15, 30);
	}


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		LimitBoundary ();
		SpawnTime ();
	}

	// Spawner Time Span

	void SpawnTime(){
		if(GameplayController.instance.gameInProgress){
			time += Time.deltaTime;
			if(time >= delay){
				time = 0;
				delay = Random.Range (15, 30);
				Instantiate (battery, new Vector3 (Random.Range (maxleft + 1f, maxRight - 1f), maxTop, transform.position.z), Quaternion.Euler(new Vector3(0, 0, -90)));
			}

		}
	}

	// Limit Spawn Object X Position

	void LimitBoundary(){
		Vector3 leftBound = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, Camera.main.transform.position.z + 10));
		Vector3 righBound = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, Camera.main.transform.position.z + 10));
		Vector3 topBound = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, Camera.main.transform.position.z + 10));
		maxleft = leftBound.x;
		maxRight = righBound.x;
		maxTop = topBound.y;
	}
}
