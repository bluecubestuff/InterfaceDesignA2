using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAdjust : MonoBehaviour {

    private void Start()
    {
        Vector3 position = new Vector3(Screen.width / 2, Screen.height / 2, 1);
        transform.position = position;
        Vector3 scale = new Vector3(Screen.width, Screen.height, 1);
        transform.localScale = scale;
    }
}
