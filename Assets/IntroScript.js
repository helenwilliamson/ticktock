#pragma strict

//attach to empty game object

var bgIntro : Texture2D;
var btnPlay : Texture2D;

var showIntro : boolean;

function OnGUI() {
	//show intro/outro		
	if (showIntro == true) {
		GUI.Label(Rect(50, 0,900,900), bgIntro);
		
		if (Event.current.type == EventType.KeyDown) {
        	showIntro = false;
    	}	
	} 
}