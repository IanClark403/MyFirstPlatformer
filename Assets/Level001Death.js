var target : Transform;

function Update () {
}
function OnTriggerEnter (col : Collider) {
	if(col.gameObject.tag == "level001death") {
		this.transform.position = target.position;
	}
}