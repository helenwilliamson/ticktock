using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	
	public Texture2D introScreen;
	public Texture2D winScreen;
	public Texture2D loseScreen;
	public Texture2D creditsScreen;
	
	private int oil = 0;
	private int water = 0;
	
	enum Status { Intro, Playing, Won, Lost, Credits };
	
	private Status status = Status.Intro;
	
	void OnGUI () {
		switch (status) {
			case Status.Intro:
				showIntro();
				return;
			case Status.Playing:
				showScore();
				return;
			case Status.Won:
				showWinScreen();
				return;
			case Status.Lost:
				showLoseScreen();
				return;
			case Status.Credits:
				showCreditsScreen();
				return;
		}
	}

	void showIntro() {
		GUI.DrawTexture(new Rect(0, 0,960,600), introScreen);
			
		if (Event.current.type == EventType.KeyDown) {
			status = Status.Playing;
	    }
	}

	void showScore() {
		GUI.Box(new Rect(10,10,100,30), "Oil: " + oil);
		GUI.Box(new Rect(10,50,100,30), "Water: " + water);
	}
	
	void showWinScreen() {
		Debug.Log("Showing win");
		GUI.DrawTexture(new Rect(0, 0,960,600), winScreen);
		StartCoroutine(pause(Status.Credits));
	}
	
	void showLoseScreen() {
		Debug.Log("Showing lose");
		GUI.DrawTexture(new Rect(0, 0,960,600), loseScreen);
		StartCoroutine(pause(Status.Credits));
	}
	
	void showCreditsScreen() {
		Debug.Log("Showing credits");
		oil = 0;
		water = 0;
		
		GUI.DrawTexture(new Rect(0, 0,960,600), creditsScreen);
		StartCoroutine(pause(Status.Intro));
	}
	
	IEnumerator pause(Status newStatus) {
		Debug.Log("Pausing");
		yield return new WaitForSeconds(2);
		Debug.Log("Changing status to " + newStatus);
		status = newStatus;
	}
	
	public void hitOil() {
		oil++;
		if (oil == 10) {
			status = Status.Won;
		}
	}
	
	public void hitWater() {
		water++;
		if (water == 5) {
			status = Status.Lost;
		}
	}
	
	public bool started() {
		return status == Status.Playing;
	}
	
}