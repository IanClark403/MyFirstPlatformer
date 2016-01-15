var target : Transform;

function Update () {
}
function OnTriggerEnter (col : Collider) {
	if(col.gameObject.tag == "level001finish") {
		this.transform.position = target.position;
	}
}