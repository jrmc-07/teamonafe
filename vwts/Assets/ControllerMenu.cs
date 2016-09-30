using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControllerMenu : MonoBehaviour {

	SteamVR_TrackedObject trackedController;
	public Text cameraMode;

	// Use this for initialization
	void Start () {
		trackedController = GetComponent<SteamVR_TrackedObject> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var device = SteamVR_Controller.Input((int)trackedController.index);

		if(device.GetPressDown (Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad))
		{
			if (device.GetAxis (Valve.VR.EVRButtonId.k_EButton_Axis0).y > 0 ) 
			{
				cameraMode.text = "TITAN MODE";
			}
			else if (device.GetAxis (Valve.VR.EVRButtonId.k_EButton_Axis0).y < 0 ) 
			{
				cameraMode.text = "HUMAN MODE";
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
