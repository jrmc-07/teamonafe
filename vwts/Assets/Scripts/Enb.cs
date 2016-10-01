using UnityEngine;
using System.Collections;

public class Enb : MonoBehaviour {
	
	private bool displayOnce = false;
	private bool spawned = false;
	public bool establishedS1 = false;
	public bool establishedS1u = false;
	float speed = 0.25f;
	
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0.0f, -40.0f, 25.0f);
		print("Setup Enb");
	}
	
	// Update is called once per frame
	void Update () {
		SpawnEnb();
	}
	
	void SpawnEnb(){
		if (!displayOnce)
		{
			print("Spawning Enb");
			displayOnce = true;
		}
		
		if (transform.position.y < 0)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
		}
		else
		{
			spawned = true;
		}
		
		if (spawned)
		{
			CreateEnbS1Link();
			CreateEnbS1uLink();
		}
	}
	
	void CreateEnbS1Link(){
		print("Enb: Creating S1 link");
		establishedS1 = true;
	}
	
	void CreateEnbS1uLink(){
		print("Enb: Creating S1u link");
		establishedS1u = true;
	}
}
