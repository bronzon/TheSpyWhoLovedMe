using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestructionSequenceSystem : MonoBehaviour {
	Timer timer;
	public Text uiText;
	public GameObject theCodeText;
	public GameObject bombChild;
	public GameObject slides;
	public GameObject inputField;
	public GameObject button;
	public Text goodWork;
	public Text timerText;

	private bool isSeen;

	void Start () {
		timer = FindObjectOfType<Timer> ();	
	}

	public void StartSequence () {
		if (isSeen) {
			return;
		}
			
		isSeen = true;
		uiText.gameObject.SetActive (false);
		bombChild.SetActive (true);
		slides.SetActive (false);
	}

	void Update () {
		if (timer.TimeIsUp () && !isSeen) {
			StartCoroutine (DoIt ());		
		}
	}

	IEnumerator DoIt ()	{
		if (isSeen) {
			yield break;
		}

		button.SetActive (false);
		slides.SetActive (false);
		inputField.SetActive (false);
		timerText.gameObject.SetActive (false);
		goodWork.gameObject.SetActive (true);
		goodWork.GetComponent<Text> ().text = "KLIPP RÄTT KABEL";
		yield return new WaitForSeconds (6);
		goodWork.gameObject.SetActive (false);

		StartSequence ();

	}

	public void CutTheWire () {
		bombChild.SetActive (false);
		uiText.gameObject.SetActive (false);
		theCodeText.gameObject.SetActive (true);
	}
}
