using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterMov : MonoBehaviour {
	
	public Vector3 movVelocity;
	private List<float> positions = new List<float>();
	private int currentPosition = 0;
	
	// Use this for initialization
	void Start () {
		positions.Add(60f);
		positions.Add(45f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Vertical") && validKeyPress()) {
			var amountToMove = 0f;
			if (Input.GetKey("down")) {
				amountToMove = -positions[currentPosition];
			}
			else if (Input.GetKey("up")) {
				amountToMove = positions[currentPosition-1];
			}
			
			gameObject.transform.Translate (0f, 0f, amountToMove);
			
			if (Input.GetKey("down")) {
				currentPosition += 1;
			}
			else if (Input.GetKey("up")) {
				currentPosition -= 1;
			}
		}

	}
	
	bool validKeyPress() {
		if ((currentPosition == 0 && Input.GetKey("up")) 
			|| (currentPosition == 2 && Input.GetKey("down"))) {
			return false;
		}
		return true;
	}
	
}
