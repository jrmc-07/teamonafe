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

			//test
			StartUeAttach();
		}
		catch(Exception){
			Debug.LogError ("Drag UE's PacketSender script to AttachProcedure script");
		}
	}

	public void StartUeAttach(){
		StartCoroutine (attachUe ());
	}

	IEnumerator attachUe()
	{
		uePacketSender.StartSendingPackets ();
		yield return new WaitForSeconds(2);
		enbPacketSender.StartSendingPackets ();
		yield return new WaitForSeconds(2);
		mmePacketSender.StartSendingPackets ();
	}

	public void StopAttach(){
		uePacketSender.StopSendingPackets ();
		enbPacketSender.StopSendingPackets ();
		mmePacketSender.StopSendingPackets ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
