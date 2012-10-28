using UnityEngine;
using System.Collections;
using System;

public class ChangeHeartMaterial : MonoBehaviour {
	
	public float duration =1f;
	
	void Update () {
		var lerp = Mathf.PingPong(Time.time, duration) / duration; 
    	renderer.material.SetFloat("_Blend", lerp );
	}
}
