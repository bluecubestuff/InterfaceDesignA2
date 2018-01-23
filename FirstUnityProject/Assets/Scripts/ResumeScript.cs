using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeScript : MonoBehaviour {

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public void OnClick()
    {
        PauseScript.paused = false;
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
