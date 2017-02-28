using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public int minutes = 10;
	public Text uiText;
	private bool isStarted;
	private float timeRemaining = 0f;

	void Awake() {
		StartTimer ();
	}

	public void StartTimer() {
		timeRemaining = minutes*60f;
		isStarted = true;	
	}

	public void StopTimer() {
		isStarted = false;
	}

	void Update() {
		if (isStarted) {
			timeRemaining -= Time.deltaTime;
		
			if (timeRemaining <= 0) {
				timeRemaining = 0;
				StopTimer ();
			}
			uiText.text = ToString ();
		}

	}

	public override string ToString() {
		var secs = Mathf.FloorToInt(timeRemaining % 60);
		var mins = Mathf.FloorToInt(timeRemaining / 60);

		return String.Format("{0:00}:{1:00}", mins, secs);
	}

	public bool TimeIsUp ()	{
		return timeRemaining == 0;
	}
}
