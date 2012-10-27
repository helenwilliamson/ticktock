using UnityEngine;
using System.Collections;
using System;

public class ChangeHeartMaterial : MonoBehaviour {
	
	public Material[] materials;
	
	// Update is called once per frame
	void Update () {
		var currentMaterial = renderer.material;
		if ((DateTime.Now.Millisecond / 100) % 5 == 0) {
			if (materials[0] == currentMaterial) {
				renderer.material = materials[1];
			}
			else {
				renderer.material = materials[0];
			}
		}
	}
}
