using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mytry : MonoBehaviour {

	public Text cameraMode;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		#if UNITY_EDITOR
		Debug.Log("in UNITY");
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			Debug.Log("TITAN MODE");
			cameraMode.text = "TITAN MODE >";
			Vector3 titan = new Vector3(transform.position.x ,18f, transform.position.z);
			transform.position = titan;
			transform.localScale = new Vector3(30.0f, 30.0f, 30.0f);
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			Debug.Log("HUMAN MODE");
			cameraMode.text = "< HUMAN MODE";
			transform.position = new Vector3(transform.position.x ,1.5f, transform.position.z);
			transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
		}
		#endif
	}
}
