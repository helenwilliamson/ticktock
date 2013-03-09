using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterCollision : MonoBehaviour {
	
	public GameObject ui;
	public List<AudioClip> pickupSounds;
	public List<AudioClip> obstacleSounds;

	void OnCollisionEnter(Collision colidedWith) {
		if (getUIScript().started()) {
			var tag = colidedWith.gameObject.tag;
			Debug.Log("Collided with: " + colidedWith + " tagged: " + tag);
			if (tag == "pickup") {
				handlePickup(colidedWith.gameObject);	
			}
			else if (tag == "obstacle") {
				handleObstacle();	
			}
		}
	}
	
	void handlePickup(GameObject gameObject) {
		Destroy(gameObject);
		
		playSound(pickupSounds);
		
		getUIScript().hitOil();
	}
	
	void playSound(List<AudioClip> sounds) {
		var clip = sounds[Random.Range(0, sounds.Count)];
		AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, 0.6f);
	}
	
	void handleObstacle() {
		var heart = GameObject.Find("Heart");
		var changeHeartMaterial = heart.GetComponent<ChangeHeartMaterial>();
		changeHeartMaterial.duration += 0.3f;
		
		playSound(obstacleSounds);
		
		getUIScript().hitWater();
	}
	
	private UI getUIScript() {
		return ui.GetComponent<UI>();	
	}
	
}
