using UnityEngine;
using System.Collections;

public class CharacterCollision : MonoBehaviour {
	
	public GameObject ui;

	void OnCollisionEnter(Collision colidedWith) {
		Debug.Log ("Tagged: " + colidedWith.gameObject.tag);
		var tag = colidedWith.gameObject.tag;
		if (tag == "pickup") {
			handlePickup(colidedWith.gameObject);	
		}
	}
	
	void handlePickup(GameObject gameObject) {
		Destroy(gameObject);
		
		var component = ui.GetComponent<UI>();
		component.numberCollected += 1;
	}
}
