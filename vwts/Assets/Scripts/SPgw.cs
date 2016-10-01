using UnityEngine;
using System.Collections;

public class SPgw : MonoBehaviour {
	
	public GameObject S1uTunnel;
	private bool displayOnce = false;
	public bool spawned = false;
	private bool establishedS1u = true;
	float speed = 0.25f;
	
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(25f, -40.0f, -3.5f);
		print("Setup SPgw");
	}
	
	// Update is called once per frame
	void Update () {
		SpawnSPgw();
	}
	
	void SpawnSPgw(){
		if (!displayOnce)
		{
			print("Spawning SPgw");
			displayOnce = true;
		}
		
		if (transform.position.y < 0)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
		}
	}
	
	void CreateSPgwS1uLink(){
		print("SPgw: Creating S1u link");
		establishedS1u = true;
	}
}
