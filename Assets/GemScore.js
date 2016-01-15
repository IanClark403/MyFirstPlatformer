static var gscore : int = 0;

function OnGUI () {
	GUI.Label (Rect (10, 10, 150, 20), ("Gems Collected: " + gscore));
}