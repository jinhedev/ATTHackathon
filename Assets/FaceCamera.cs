using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{

    private GameObject MainCam = null;

	// Use this for initialization
	void Start () {
		MainCam = GameObject.FindWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
	    if (MainCam != null)
	    {
	        transform.LookAt(MainCam.transform);
           // transform.Rotate(0,180,0);
	    }
	}
}
