using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupSpawner : MonoBehaviour {
	
	public Transform collectiblePrefab;
	public List<int> positions;
	public Vector3 startingPosition;
	public float scale;
	
	public void Spawn() {
		var initialPosition = transform.localPosition;
		initialPosition.x = startingPosition.x;
		initialPosition.y = startingPosition.y;
		initialPosition.z = startingPosition.z;
		
		foreach (int amountToAdd in positions) {
			Transform collectible = (Transform)Instantiate(collectiblePrefab);
			collectible.transform.parent = gameObject.transform;
			collectible.localPosition = startingPosition;
			collectible.localScale = new Vector3(scale, 0.1f, scale);
			
			collectible.RotateAround(Vector3.zero, Vector3.up, amountToAdd);
		}
	}
}
