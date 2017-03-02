using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructIn : MonoBehaviour {
	public float time = 2;
	// Use this for initialization
	void Start () {
		StartCoroutine (KillMe ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator KillMe () {
		yield return new WaitForSeconds(time);
		GetComponent<Animator> ().Stop ();
	}
}
