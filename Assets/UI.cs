using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	
	public Texture2D introBackground;
	public bool showIntro;

	void OnGUI () {
		if (showIntro == true) {
			GUI.Label(new Rect(50, 0,900,900), introBackground);
		
			if (Event.current.type == EventType.KeyDown) {
        		showIntro = false;
    		}	
		} 
	}
	
}