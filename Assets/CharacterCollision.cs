using UnityEngine;
using System.Collections;

public class CharacterCollision : MonoBehaviour {

	void OnCollisionEnter(Collision colidedWith) {
		Destroy(colidedWith.gameObject);
	}
}
