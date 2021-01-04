using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	public static MusicController instance;

	public AudioClip[] audioClips;

	private AudioSource audioSource;

	void Awake(){
		MakeInstance ();
		audioSource = GetComponent<AudioSource> ();	
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Create Instance Of Music Controller

	void MakeInstance(){
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	//Play Main Background Music

	public void PlayerBGMusic(){
		AudioClip bgMusic = audioClips [0];

		if(bgMusic){
			if(!audioSource.isPlaying){
				audioSource.clip = bgMusic;
				audioSource.loop = true;
				audioSource.volume = 1f;
				audioSource.Play ();
			}
		}
	}

	//Play Gameplay Music

	public void GameplayBgMusic(){
		AudioClip gameplayMusic = audioClips [1];

		if(gameplayMusic){
			audioSource.clip = gameplayMusic;
			audioSource.loop = true;
			audioSource.volume = 1f;
			audioSource.Play ();
		}
	}

	//Stop Playing Background Music

	public void StopBgMusic(){
		if(audioSource.isPlaying){
			audioSource.Stop ();
		}
	}

	public void ClickSound(){
		audioSource.PlayOneShot (audioClips [2], 1f);
	}
}
