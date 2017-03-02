using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class center : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		var pos = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane));
		pos = new Vector3 (pos.x, pos.y, 0);
		transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {
		var pos = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane));
		pos = new Vector3 (pos.x, pos.y, 0);
		transform.position = pos;
	}
}
