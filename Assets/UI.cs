using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	
	public Texture2D introBackground;
	public bool showIntro;
	public int numberCollected = 0;

	void OnGUI () {
		if (showIntro) {
			GUI.Label(new Rect(50, 0,900,900), introBackground);
		
			if (Event.current.type == EventType.KeyDown) {
        		showIntro = false;
    		}	
		}
		
		if (!showIntro) {
			updateUI();	
		}
	}
	
	void updateUI() {
		GUI.Box(new Rect(10,10,100,30), "Collected: " + numberCollected);
	}
	
}