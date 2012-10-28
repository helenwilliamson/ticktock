using UnityEngine;
using System.Collections;

public class CharacterMov : MonoBehaviour {
	

	public Vector3 movVelocity;
	
	private Vector3 startPosition,lastPosition,distanceTraveled;
	
	
	// Use this for initialization
	void Start () {
	     startPosition = transform.localPosition;
		 lastPosition = transform.localPosition;
		 distanceTraveled = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Vertical")){
		   //Debug.Log("Move: " + this.gameObject.name);
			//print("down key was pressed");
			
			 if (Input.GetKey("up")) {
                //print("up arrow key is held down");
				if (distanceTraveled.z < 240) {
				  gameObject.transform.Translate(0f,0f,60f);
			    }
			}
        
        if (Input.GetKey("down")) {
            //print("down arrow key is held down");
			if (distanceTraveled.z > 60) {
				  gameObject.transform.Translate(0f,0f,-60f);
		 }
		}
			
			
   
		  //rigidbody.AddForce(0f,0f,30f, ForceMode.VelocityChange);	
		}
	    distanceTraveled = transform.localPosition;

	}
	/*
	void FixedUpdate () {
		if(touchingPlatform){
			rigidbody.AddForce(acceleration, 0f, 0f, ForceMode.Acceleration);
		}
	}
	*/
	
	 void FixedUpdate() {
        rigidbody.AddForce(0f, 0f, 60f);
    }
}
