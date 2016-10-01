using UnityEngine;
using System.Collections;

public class Mme : MonoBehaviour {
	
	private bool displayOnce = false;
	private bool spawned = false;
	public bool establishedS1 = false;
	float speed = 0.25f;
	
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(-31.4f, -40.0f, 3.5f);
		print("Setup Mme");
	}
	
	// Update is called once per frame
	void Update () {
		SpawnMme();
	}
	
	void SpawnMme(){
		if (!displayOnce)
		{
			print("Spawning Mme");
			displayOnce = true;
		}
		
		if (transform.position.y < 0)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
		}
	}
	
	void CreateMmeS1Link(){
		print("Mme: Creating S1 link");
		establishedS1 = true;
	}
}
