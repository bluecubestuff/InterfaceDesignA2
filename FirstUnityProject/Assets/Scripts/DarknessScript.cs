using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarknessScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().enabled = false;
        Vector3 position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        transform.position = position;
        Vector3 scale = new Vector3(Screen.width, Screen.height, 1);
        transform.localScale = scale;
    }
	
	// Update is called once per frame
	void Update () {
		if (PauseScript.paused)
            GetComponent<Renderer>().enabled = true;
        else
            GetComponent<Renderer>().enabled = false;
    }
}
