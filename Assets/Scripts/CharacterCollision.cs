using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterCollision : MonoBehaviour {
	
	public GameObject ui;
	public List<AudioClip> pickupSounds;

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
		
		playSound();
		
		getUIScript().numberCollected += 1;
	}
	
	void playSound() {
		var clip = pickupSounds[Random.Range(0, pickupSounds.Count)];
		AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
	}
	
	void handleObstacle() {
		var heart = GameObject.Find("Heart");
		var changeHeartMaterial = heart.GetComponent<ChangeHeartMaterial>();
		changeHeartMaterial.duration += 0.5f;
		
		//StartCoroutine(showFinishScreen());
	}
	
	IEnumerator showFinishScreen() {
		yield return new WaitForSeconds(2);
		getUIScript().finished = true;
	}
	
	private UI getUIScript() {
		return ui.GetComponent<UI>();	
	}
	
}
