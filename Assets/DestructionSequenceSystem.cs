using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestructionSequenceSystem : MonoBehaviour {
	Timer timer;
	public Text uiText;
	public GameObject bombChild;
	private bool isSeen;
	// Use this for initialization
	void Start () {
		timer = FindObjectOfType<Timer> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (timer.TimeIsUp () && !isSeen) {
			isSeen = true;
			uiText.gameObject.SetActive (false);
			bombChild.SetActive (true);
		}
	}

	public void CutTheWire () {
		bombChild.SetActive (false);
		uiText.gameObject.SetActive (true);
		uiText.text = "Grattis, Koden är 5543";
	}
}
