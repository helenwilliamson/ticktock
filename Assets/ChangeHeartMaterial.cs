using UnityEngine;
using System.Collections;
using System;

public class ChangeHeartMaterial : MonoBehaviour {
	
	public Material[] materials;
	public float duration =1f;
	
	// Update is called once per frame
	void Update () {
		//var currentMaterial = renderer.material;
		//if ((DateTime.Now.Millisecond / 100) % 5 == 0) {
		//	float lerp = Mathf.PingPong(Time.time, duration) / duration;
		//	if (materials[0] == currentMaterial) {
        //		renderer.material.Lerp(materials[0], materials[1], lerp);
		//	}
		//	else {
		//		renderer.material.Lerp(materials[1], materials[0], lerp);
		//	}
		//}
		
		var lerp = Mathf.PingPong(Time.time, duration) / duration; 
    	renderer.material.SetFloat("_Blend", lerp );
	}
}
