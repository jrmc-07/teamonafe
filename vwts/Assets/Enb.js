#pragma strict
private var SecondsPassed : float = 0.0;
function Start () {
	transform.position = Vector3.up * 100.0;
}

function Update () {
	SecondsPassed += Time.deltaTime;
	SpawnEnb();
}

function SpawnEnb(){
	if(transform.position.y > 0)
		transform.position += Vector3.down * 0.5;
}