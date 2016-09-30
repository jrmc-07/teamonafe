using UnityEngine;
using System.Collections;

public class PacketSender : MonoBehaviour {

	public GameObject packet;

	public GameObject targetObject;

	public float spawnRate = 10f;
	public float packetDestroyTime = 1f;

	public float xPacketRotation = 0;
	public float yPacketRotation = 0;
	public float zPacketRotation = 90;

	public float xPacketOriginOffset = 0;
	public float yPacketOriginOffset = 0;
	public float zPacketOriginOffset = 0;

	public float xPacketTargetOffset = 0;
	public float yPacketTargetOffset = 0;
	public float zPacketTargetOffset = 0;

	// Use this for initialization
	void Start () {
		//InvokeRepeating ("movePackets", .0f, 1/spawnRate);
	}

	// Update is called once per frame
	void Update () {
	}

	public void StartSendingPackets(){
		InvokeRepeating ("sendPackets", 0.0f, 1 / spawnRate);
	}

	public void StopSendingPackets(){
		CancelInvoke ("movePackets");
	}

	void movePackets(){
		GameObject p = (GameObject)Instantiate (packet, 
			new Vector3 (
				gameObject.transform.position.x + xPacketOriginOffset, 
				gameObject.transform.position.y + yPacketOriginOffset, 
				gameObject.transform.position.z + zPacketOriginOffset), 
			Quaternion.Euler(xPacketRotation, yPacketRotation, zPacketRotation));
		
		iTween.MoveTo (p, 
			iTween.Hash(
				"x", targetObject.transform.position.x + xPacketTargetOffset, 
				"y", targetObject.transform.position.y + yPacketTargetOffset, 
				"z", targetObject.transform.position.z + zPacketTargetOffset, 
				"easeType", "easeInOutSine", 
				"loopType", "loop", 
				"delay", .1));
		Destroy (p, packetDestroyTime);
	}
}
