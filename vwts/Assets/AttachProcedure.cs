using UnityEngine;
using System.Collections;
using System;

public class AttachProcedure : MonoBehaviour {
	public PacketSender uePacketSender;

	private PacketSender enbPacketSender;
	private PacketSender mmePacketSender;

	// Use this for initialization
	void Start () {
		try{
			enbPacketSender = uePacketSender.GetComponent <PacketSender> ().targetObject.GetComponent<PacketSender> ();
			mmePacketSender = uePacketSender.GetComponent <PacketSender> ().targetObject.GetComponent<PacketSender> ().targetObject.GetComponent<PacketSender> ();
			StartCoroutine(AttachUe());
		}
		catch(Exception){
			Debug.LogError ("Drag UE's PacketSender script to AttachProcedure script");
		}
	}


	IEnumerator AttachUe()
	{
		uePacketSender.StartSendingPackets ();
		yield return new WaitForSeconds(2);
		enbPacketSender.StartSendingPackets ();
		yield return new WaitForSeconds(2);
		mmePacketSender.StartSendingPackets ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
