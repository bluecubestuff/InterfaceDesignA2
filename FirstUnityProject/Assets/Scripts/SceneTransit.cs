using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransit : MonoBehaviour {

    [SerializeField]
    Canvas mainMenu;

    [SerializeField]
    Canvas optionsCanvas;

    [SerializeField]
    Canvas highscoreCanvas;

    Canvas currentCanvas;

    protected void Start()
    {
        optionsCanvas.enabled = false;
        highscoreCanvas.enabled = false;
    }
    public void Game()
    {
        SceneManager.LoadScene("InGame"); //load title of scene
    }

    public void Options()
    {
        mainMenu.enabled = false;
        optionsCanvas.enabled = true;

        currentCanvas = optionsCanvas;
    }

    public void HighScore()
    {
        mainMenu.enabled = false;
        highscoreCanvas.enabled = true;

        currentCanvas = highscoreCanvas;
    }

    public void Back() // options back btn, highscore back btn
    {
        mainMenu.enabled = true;

        //if option, options canvas disable, 
        //if highscore, highscore canvas disable
        currentCanvas.enabled = false;
    }

}
