using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starter : MonoBehaviour {
	public GameObject inputField;
	public SlidesSystem slidesSystem;

	public void StartItAll() {
		inputField.SetActive (true);
		slidesSystem.StartSlideShow ();
		gameObject.SetActive (false);
	}
}
