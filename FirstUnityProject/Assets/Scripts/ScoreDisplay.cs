using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    private Text text;

    private void Start()
    {
        text = gameObject.GetComponent<Text>();
        text.text = "Score:";
    }

    // Update is called once per frame
    void Update () {
        text.text = "Score: " + GameController.score;
	}
}
