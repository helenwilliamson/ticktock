using UnityEngine;
using System.Collections;

public class CharacterCollision : MonoBehaviour {
	
	public GameObject ui;

	void OnCollisionEnter(Collision colidedWith) {
		Destroy(colidedWith.gameObject);
		var component = ui.GetComponent<UI>();
		component.numberCollected += 1;
	}
}
