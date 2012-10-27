using UnityEngine;
using System.Collections;

public class CharacterKeeperAlive : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.RotateAround(Vector3.zero, Vector3.up, 1);
	}
}
