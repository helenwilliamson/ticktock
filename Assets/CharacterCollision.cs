using UnityEngine;
using System.Collections;

public class CharacterCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	//void OnCollisionEnter (Collision colidedWith) {
	//	Debug.Log("Hit something: " + colidedWith.gameObject.name);
	//}
	
	void OnCollisionEnter(Collision colidedWith) {
		Debug.Log("Hit something: " + colidedWith.gameObject.name);
	}
	
	void OnTriggerEnter(Collider otherObj) {
			Debug.Log("Hit something: " + otherObj.gameObject.name);
	}
}
