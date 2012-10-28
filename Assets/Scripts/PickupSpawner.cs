using UnityEngine;
using System.Collections;

public class PickupSpawner : MonoBehaviour {
	
	public Transform collectiblePrefab;
	public int numberOfCollectibles;
	public Vector3 startingPosition;
	public float scale;
	
	void Start() {
		var amountToAdd = 360f / numberOfCollectibles;
		var ratioAmountToAdd = amountToAdd*0.6f;
		var initialPosition = transform.localPosition;
		initialPosition.x = startingPosition.x;
		initialPosition.y = startingPosition.y;
		initialPosition.z = startingPosition.z;
		
		for (int i = 1; i < numberOfCollectibles; i++) {
			Transform collectible = (Transform)Instantiate(collectiblePrefab);
			collectible.transform.parent = gameObject.transform;
			collectible.localPosition = startingPosition;
			collectible.localScale = new Vector3(scale, 0.1f, scale);
			
			collectible.RotateAround(Vector3.zero, Vector3.up, (amountToAdd*i)+Random.Range(-ratioAmountToAdd, ratioAmountToAdd));
		}
	}
}
