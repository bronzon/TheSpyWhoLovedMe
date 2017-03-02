using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starter : MonoBehaviour {
	public GameObject inputField;
	public SlidesSystem slidesSystem;
	public GameObject music;
	public GameObject agent;

	public void StartItAll() {
		agent.SetActive (false);
		inputField.SetActive (true);
		slidesSystem.StartSlideShow ();
		gameObject.SetActive (false);
		Instantiate (music);
	}
}
