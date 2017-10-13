using UnityEngine;
using System;

public class InputsStandard : MonoBehaviour {

	public static Action<KeyCode, Vector3> StandardInput;

	void Update () {
		StandardInput(KeyCode.W, Vector3.up);
		StandardInput(KeyCode.S, Vector3.down);
		StandardInput(KeyCode.D, Vector3.forward);
		StandardInput(KeyCode.A, Vector3.back);
	}
}
