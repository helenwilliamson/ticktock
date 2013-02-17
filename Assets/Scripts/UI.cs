using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	
	public Texture2D introScreen;
	public bool showIntro;
	public Texture2D finishScreen;
	public bool finished;
	
	public int numberCollected = 0;

	void OnGUI () {
		if (showIntro) {
			GUI.Label(new Rect(50, 0,800,800), introScreen);
		
			if (Event.current.type == EventType.KeyDown) {
        		showIntro = false;
    		}	
		}
		
		if (!showIntro) {
			updateUI();	
		}
		
		if (finished) {
			GUI.Label(new Rect(50, 0, 900, 900), finishScreen);	
		}
	}
	
	void updateUI() {
		GUI.Box(new Rect(10,10,100,30), "Collected: " + numberCollected);
	}
	
}