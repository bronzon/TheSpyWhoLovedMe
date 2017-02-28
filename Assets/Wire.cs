using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour {
	public DestructionSequenceSystem destructionSequenceSystem;
	void OnMouseDown() {
		destructionSequenceSystem.CutTheWire ();
	}
}
