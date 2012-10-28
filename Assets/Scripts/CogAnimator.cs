using UnityEngine;
using System.Collections;
using System;

public class CogAnimator : MonoBehaviour {
	
	public Transform cog;
	public float amountToRotate;
	
	public GameObject ui;
	public bool stopped = false;
	
	private int timing = 100;
	
	// Update is called once per frame
	void Update () {
		if (amountToRotate == 0) {
			return;
		}
		
		if (HaveStarted()) {
			// Used negative speed to rotate in opposite direction
			if ((DateTime.Now.Millisecond / timing) % 5 == 0) {
				if (stopped) {
					timing = 1;
					amountToRotate /= 2;
					if (Math.Round(Mathf.Round(amountToRotate * 1000)) == 0) {
						amountToRotate = 0;	
					}
				}
				
				cog.RotateAround(Vector3.zero, Vector3.up, amountToRotate);
			}
		}
	}
	
	bool HaveStarted() {
		var component = ui.GetComponent<UI>();
		return !component.showIntro;
	}
	
}
