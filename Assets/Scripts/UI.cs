using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	
	public Texture2D introScreen;
	public Texture2D winScreen;
	public Texture2D loseScreen;
	public Texture2D creditsScreen;
	
	private bool finished = false;
	private bool showIntro = true;
	
	private int oil = 0;
	private int water = 0;

	void OnGUI () {
		if (finished) {
			if (oil == 10) {
				GUI.DrawTexture(new Rect(0, 0,960,600), winScreen);
			}
			else {
				GUI.DrawTexture(new Rect(0, 0,960,600), loseScreen);
			}
		}
		else {
			if (showIntro) {
				GUI.DrawTexture(new Rect(0, 0,960,600), introScreen);
			
				if (Event.current.type == EventType.KeyDown) {
	        		showIntro = false;
	    		}	
			}
			else {
				GUI.Box(new Rect(10,10,100,30), "Oil: " + oil);
				GUI.Box(new Rect(10,50,100,30), "Water: " + water);
			}
		}
	}
	
	public void hitOil() {
		oil++;
		if (oil == 10) {
			finished = true;
		}
	}
	
	public void hitWater() {
		water++;
		if (water == 5) {
			finished = true;
		}
	}
	
	public bool started() {
		return showIntro == false && finished != true;
	}
	
}