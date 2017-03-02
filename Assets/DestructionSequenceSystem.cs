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
	public Text timerText;
	public GameObject cutTheWireGuy;
	public GameObject agent;

	private bool isSeen;

	void Start () {
		timer = FindObjectOfType<Timer> ();	
	}

	public void StartSequence () {
		print ("databanan");
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
		agent.SetActive (false);
		button.SetActive (false);
		slides.SetActive (false);
		inputField.SetActive (false);
		timerText.gameObject.SetActive (false);
		cutTheWireGuy.gameObject.SetActive (true);
		yield return new WaitForSeconds (20);
		cutTheWireGuy.gameObject.SetActive (false);
		StartSequence ();
	}

	public void CutTheWire () {
		bombChild.SetActive (false);
		uiText.gameObject.SetActive (false);
		theCodeText.gameObject.SetActive (true);
	}
}
