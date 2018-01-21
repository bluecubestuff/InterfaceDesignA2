using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransit : MonoBehaviour
{
    [SerializeField]
    Canvas splashScreen;
    [SerializeField]
    Canvas mainMenu;
    [SerializeField]
    Canvas optionsCanvas;

    Canvas currentCanvas;

    protected void Start()
    {
        optionsCanvas.enabled = false;
        mainMenu.enabled = false;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0) && splashScreen.enabled)
        {
            MainMenu();
        }
    }

    public void Game()
    {
        SceneManager.LoadScene("InGame"); //load title of scene
    }

    public void SplashScreen()
    {

    }

    public void MainMenu()
    {
        splashScreen.enabled = false;
        mainMenu.enabled = true;

        currentCanvas = mainMenu;
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
        //highscoreCanvas.enabled = true;

        //currentCanvas = highscoreCanvas;
    }

    public void Back() // options back btn, highscore back btn
    {
        mainMenu.enabled = true;

        //if option, options canvas disable, 
        //if highscore, highscore canvas disable

        currentCanvas.enabled = false;
    }

}
