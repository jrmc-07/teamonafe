using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControllerMenu : MonoBehaviour {

	SteamVR_TrackedObject trackedController;
	public Text cameraMode;
	public Transform camera;

	// Use this for initialization
	void Start () {
		trackedController = GetComponent<SteamVR_TrackedObject> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Debug.Log("in Vive");
	
		var device = SteamVR_Controller.Input((int)trackedController.index);

		if(device.GetPressDown (Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad))
		{
			Debug.Log("Press Down");
			if (device.GetAxis (Valve.VR.EVRButtonId.k_EButton_Axis0).x > 0 ) 
			{		
				Debug.Log("Titan Mode");
				cameraMode.text = "TITAN MODE >";
				camera.transform.localScale = new Vector3(30.0f, 30.0f, 30.0f);
			}
			else if (device.GetAxis (Valve.VR.EVRButtonId.k_EButton_Axis0).x < 0 ) 
			{
				Debug.Log("Human Mode");
				cameraMode.text = "< HUMAN MODE";
				camera.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
			}

		}

/*		

        // Position in touch pad
		if (device.GetAxis (Valve.VR.EVRButtonId.k_EButton_Axis0).y > 0) {
		// TAP
			if(device.GetPressDown(Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad)
		} else {
		}
		*/		
	}
}
