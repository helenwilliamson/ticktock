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
		
		getUIScript().numberCollected += 1;
	}
	
	void handleObstacle() {
		var cogAnimators = gameObject.transform.parent.GetComponents<CogAnimator>();
		foreach(CogAnimator cogAnimator in cogAnimators) {
			cogAnimator.stopped = true;
		}
		
		StartCoroutine(showFinishScreen());
	}
	
	IEnumerator showFinishScreen() {
		yield return new WaitForSeconds(5);
		getUIScript().finished = true;
	}
	
	private UI getUIScript() {
		return ui.GetComponent<UI>();	
	}
	
}
