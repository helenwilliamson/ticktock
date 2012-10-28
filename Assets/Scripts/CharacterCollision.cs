using UnityEngine;
using System.Collections;

public class CharacterCollision : MonoBehaviour {
	
	public GameObject ui;

	void OnCollisionEnter(Collision colidedWith) {
		var tag = colidedWith.gameObject.tag;
		if (tag == "pickup") {
			handlePickup(colidedWith.gameObject);	
		}
		else if (tag == "obstacle") {
			handleObstacle();	
		}
	}
	
	void handlePickup(GameObject gameObject) {
		Destroy(gameObject);
		
		var component = ui.GetComponent<UI>();
		component.numberCollected += 1;
	}
	
	void handleObstacle() {
		var cogAnimators = gameObject.transform.parent.GetComponents<CogAnimator>();
		foreach(CogAnimator cogAnimator in cogAnimators) {
			cogAnimator.stopped = true;
		}
	}
	
}
