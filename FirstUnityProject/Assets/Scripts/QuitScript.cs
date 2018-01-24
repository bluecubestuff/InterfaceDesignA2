using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitScript : MonoBehaviour {

    public static GameObject me;

	// Use this for initialization
	void Start () {
        me = gameObject;
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
