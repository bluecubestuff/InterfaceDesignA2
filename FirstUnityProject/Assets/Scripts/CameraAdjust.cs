using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAdjust : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector3 position = new Vector3(Screen.width / 2, Screen.height / 2, -5);
        transform.position = position;
        gameObject.GetComponent<Camera>().orthographicSize = Screen.height / 2;
    }
}
