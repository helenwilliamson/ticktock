using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	
	public Texture2D introScreen;
	public Texture2D winScreen;
	public Texture2D loseScreen;
	public Texture2D creditsScreen;
	
	private int oil = 0;
	private int water = 0;
	
	enum Status { Reset, Intro, Playing, Won, Lost, Credits };
	
	private Status status = Status.Reset;
	
	void OnGUI () {
		switch (status) {
			case Status.Reset:
				resetAndShowIntro();
				return;
			case Status.Intro:
				showIntroAndCheckIfReady();
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
	
	void resetAndShowIntro() {
		Debug.Log("Resetting");
		showIntro();
		
		foreach (GameObject obstacle in GameObject.FindGameObjectsWithTag("obstacle")) {
			Destroy(obstacle);
		}
		Debug.Log("Destroyed all obstacles");
		
		foreach (GameObject pickup in GameObject.FindGameObjectsWithTag("pickup")) {
			Destroy(pickup);
		}
		Debug.Log("Destroyed all pickups");
		
		GameObject character = GameObject.FindGameObjectWithTag("character");
		CharacterMov movement = character.GetComponent<CharacterMov>();
		movement.MoveOffScreen();
		Debug.Log("Moved character off screen");
		
		foreach (GameObject cog in GameObject.FindGameObjectsWithTag("cog")) {
			foreach (PickupSpawner spawner in cog.GetComponents<PickupSpawner>()) {
				spawner.Spawn();	
			}
		}
		Debug.Log("Respawned pickups and obstacles");
		movement.Reset();
		Debug.Log("Moved character back on screen");
		
		status = Status.Intro;
	}

	void showIntro() {
		GUI.DrawTexture(new Rect(0, 0,960,600), introScreen);
	}
	
	void showIntroAndCheckIfReady() {
		showIntro();
			
		if (Event.current.type == EventType.KeyDown) {
			status = Status.Playing;
	    }
	}

	void showScore() {
		GUI.Box(new Rect(10,10,100,30), "Oil: " + oil);
		GUI.Box(new Rect(10,50,100,30), "Water: " + water);
	}
	
	void showWinScreen() {
		GUI.DrawTexture(new Rect(0, 0,960,600), winScreen);
		StartCoroutine(pause(Status.Credits));
	}
	
	void showLoseScreen() {
		GUI.DrawTexture(new Rect(0, 0,960,600), loseScreen);
		StartCoroutine(pause(Status.Credits));
	}
	
	void showCreditsScreen() {
		oil = 0;
		water = 0;
		
		GUI.DrawTexture(new Rect(0, 0,960,600), creditsScreen);
		StartCoroutine(pause(Status.Reset));
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