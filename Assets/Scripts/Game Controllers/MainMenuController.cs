using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

	public GameObject exitPanel, settingPanel, howToPlayPanel;
	public Toggle musicToggle;
	public Text control;
	public GameObject[] infos;
	public int count = 0;

	// Use this for initialization
	void Start () {
		if (GameController.instance.isMusicOn) {
			MusicController.instance.PlayerBGMusic ();
			musicToggle.isOn = true;
		} else {
			MusicController.instance.StopBgMusic ();
			musicToggle.isOn = false;
		}

		if (GameController.instance.controls) {
			control.text = "TILT";
		} else {
			control.text = "TOUCH";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if (exitPanel.activeInHierarchy) {
				exitPanel.SetActive (false);
			} else {
				exitPanel.SetActive (true);
			}

			if (settingPanel.activeInHierarchy) {
				settingPanel.SetActive (false);
			}

		}		
	}
		

	// Play The Game

	public void PlayGame(){
		if (GameController.instance.isMusicOn) {
			MusicController.instance.ClickSound ();
		}
		SceneManager.LoadScene ("Player Menu");
	}

	// Yes Button Method

	public void YesButton(){
		Application.Quit ();
	}

	// No Button Method

	public void NoButton(){
		exitPanel.SetActive (false);
	}

	// Open Settings Button Method

	public void SettingsButton(){
		if (GameController.instance.isMusicOn) {
			MusicController.instance.ClickSound ();
		}
		settingPanel.SetActive (true);
	}

	public void HowToPlayButton(){
		if (GameController.instance.isMusicOn) {
			MusicController.instance.ClickSound ();
		}

		howToPlayPanel.SetActive (true);
	}


	// Close Settings Panel

	public void CloseButton(){
		if (GameController.instance.isMusicOn) {
			MusicController.instance.ClickSound ();
		}
		settingPanel.SetActive (false);
	}

	public void CloseInfo(){
		if (GameController.instance.isMusicOn) {
			MusicController.instance.ClickSound ();
		}
		howToPlayPanel.SetActive (false);
	}


	// Toggle Music On / Off

	public void MusicToggle(){
		if (musicToggle.isOn) {
			GameController.instance.isMusicOn = true;
			MusicController.instance.PlayerBGMusic ();
			GameController.instance.Save ();
		} else {
			GameController.instance.isMusicOn = false;
			MusicController.instance.StopBgMusic ();
			GameController.instance.Save ();
		}
	}

	// Toggle Controls Tilt / Touch

	public void Controls(){
		if (GameController.instance.controls) {
			control.text = "TOUCH";
			GameController.instance.controls = false;
			GameController.instance.Save ();
		} else {
			control.text = "TILT";
			GameController.instance.controls = true;
			GameController.instance.Save ();
		}
	}

	public void NextButton(){
		count++;
		if(count == infos.Length){
			count = 0;
		}

		for(int i = 0; i < infos.Length; i++){
			if(count == i){
				infos [i].SetActive (true);
			}else{
				infos [i].SetActive (false);
			}
		}

	}

	public void PrevButton(){
		count--;
		if(count <= 0 - 1){
			count = infos.Length - 1;
		}

		for(int i = 0; i < infos.Length; i++){
			if(count == i){
				infos [i].SetActive (true);
			}else{
				infos [i].SetActive (false);
			}
		}

	}


}
