using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlidesSystem : MonoBehaviour {
	public List<Slide> slides = new List<Slide>();
	public InputField inputField;
	private DestructionSequenceSystem destructionSequenceSystem;
	private int currentSlide = 0;
	public GameObject goodWork;
	public GameObject cutTheWireGuy;

	
	public void OnAnswerSubmitted() {		
		var slide = slides [currentSlide];
		var correctAnswer = slide.correctAnswer;
		var answer = inputField.text;
	
		answer = answer.Trim ();
		correctAnswer = correctAnswer.Trim ();

		correctAnswer = correctAnswer.ToLower ();
		answer = answer.ToLower ();

		if(correctAnswer.Equals(answer)) {
			StartCoroutine (CorrectAnswer (slide));
		}

	}

	public void StartSlideShow () {
		StartCoroutine(CorrectAnswer (slides [currentSlide]));
	}

	IEnumerator CorrectAnswer (Slide slide) 	{		
		slide.gameObject.SetActive(false);
		goodWork.gameObject.SetActive (true);
		inputField.gameObject.SetActive (false);
		yield return new WaitForSeconds (6);

		currentSlide++;
		if (currentSlide >= slides.Count) {	
			cutTheWireGuy.gameObject.SetActive (true);
			yield return new WaitForSeconds (20);
			cutTheWireGuy.gameObject.SetActive (false);
			goodWork.gameObject.SetActive (false);
			destructionSequenceSystem.StartSequence ();
		} else {
			goodWork.gameObject.SetActive (false);
			slide = slides [currentSlide];
			inputField.gameObject.SetActive (true);
			inputField.text = "";
			slide.gameObject.SetActive (true);
		}
	}

	void Start() {
		destructionSequenceSystem = FindObjectOfType<DestructionSequenceSystem> ();
	}
}
