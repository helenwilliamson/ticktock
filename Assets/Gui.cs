using UnityEngine;
using System.Collections;

public class Gui : MonoBehaviour {
	
	public int numberCollected = 0;

	void OnGUI () {
		GUI.Box(new Rect(10,10,100,90), "Collected: " + numberCollected);
	}
}
