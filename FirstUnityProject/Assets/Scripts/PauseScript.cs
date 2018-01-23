using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

    public static bool paused = false;

    public GameObject resume;
    public GameObject quit;

    public void OnClick()
    {
        paused = true;
        Time.timeScale = 0f;
        Debug.Log("Paused");
        resume.SetActive(true);
        quit.SetActive(true);
    }
}
