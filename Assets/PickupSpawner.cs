using UnityEngine;
using System.Collections;

public class PickupSpawner : MonoBehaviour {
	
	public Transform collectiblePrefab;
	public int numberOfCollectibles;
	public Vector3 startingPosition;
	
	void Start() {
		
		var amountToAdd = 360f / numberOfCollectibles;
		var initialPosition = transform.localPosition;
		initialPosition.x = startingPosition.x;
		initialPosition.y = startingPosition.y;
		initialPosition.z = startingPosition.z;
		
		for (int i = 1; i < numberOfCollectibles; i++) {
			Transform collectible = (Transform)Instantiate(collectiblePrefab);
			collectible.transform.parent = gameObject.transform;
			collectible.localPosition = startingPosition;
			
			var scale = collectible.localScale;
			scale.x = 0.05f;
			scale.y = 2.5f;
			scale.z = 0.05f;
			collectible.localScale = scale;
			
			collectible.RotateAround(Vector3.zero, Vector3.up, amountToAdd*i);
			
		}
	}
}
