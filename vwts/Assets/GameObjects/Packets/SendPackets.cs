using UnityEngine;
using System.Collections;

public class SendPackets : MonoBehaviour {

	public GameObject packet;

	public GameObject targetObject;

	public float spawnRate = 10f;
	public float packetDestroyTime = 1f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("movePackets", .0f, 1/spawnRate);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void movePackets(){
		GameObject p = (GameObject)Instantiate (packet, new Vector3 (15, 25 + 0.15f, 0), Quaternion.Euler(0,0,90));
		iTween.MoveTo (p, iTween.Hash("x", targetObject.transform.position.x, "y", targetObject.transform.position.y, "z", targetObject.transform.position.z, "easeType", "easeInOutSine", "loopType", "loop", "delay", .1));
		Destroy (p, packetDestroyTime);
	}
}
