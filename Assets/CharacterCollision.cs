using UnityEngine;
using System.Collections;

public class CharacterCollision : MonoBehaviour {

	void OnCollisionEnter(Collision colidedWith) {
		Debug.Log("Hit something: " + colidedWith.gameObject.name);
		Destroy(colidedWith.gameObject);
	}
}
