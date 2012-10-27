using UnityEngine;
using System.Collections;

public class CharacterMov : MonoBehaviour {
	
	public static float distanceTraveled;
	public Vector3 movVelocity;
	
	private Vector3 startPosition;
	
	// Use this for initialization
	void Start () {
	     startPosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Vertical")){
		   
		/*	
		   if(touchingPlatform){
				rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);
				touchingPlatform = false;
			}
			else if(boosts > 0){
				rigidbody.AddForce(boostVelocity, ForceMode.VelocityChange);
				boosts -= 1;
				GUIManager.SetBoosts(boosts);
			}
		 */
		  rigidbody.AddForce(movVelocity, ForceMode.VelocityChange);	
		}
	    distanceTraveled = transform.localPosition.x;
	}
	/*
	void FixedUpdate () {
		if(touchingPlatform){
			rigidbody.AddForce(acceleration, 0f, 0f, ForceMode.Acceleration);
		}
	}
	*/
}
