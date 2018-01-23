using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);	
	}
	
	public void OnClick()
    {
        gameObject.SetActive(false);
        //here is when quit kenna pressed
        //change scene here
        SceneManager.LoadScene("Main"); //load title of scene
    }
}
