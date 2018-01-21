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

    [SerializeField]
    Canvas shopScreen;
    [SerializeField]
    Canvas friendScreen;
    [SerializeField]
    Canvas skillScreen;
    [SerializeField]
    Canvas gearScreen;
    [SerializeField]
    Canvas heroScreen;

    Canvas currentCanvas;

    protected void Start()
    {
        optionsCanvas.enabled = false;
        mainMenu.enabled = false;
        friendScreen.enabled = false;

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
        SceneManager.LoadScene("Prototype"); //load title of scene
    }

    public void MainMenu()
    {
        splashScreen.enabled = false;
        mainMenu.enabled = true;

        currentCanvas = mainMenu;
    }

    public void FriendMenu()
    {
        mainMenu.enabled = false;
        friendScreen.enabled = true;

        currentCanvas = friendScreen;
    }

    public void Options()
    {
        mainMenu.enabled = false;
        optionsCanvas.enabled = true;

        currentCanvas = optionsCanvas;
    }

    public void Back() // options back btn, highscore back btn
    {
        mainMenu.enabled = true;
        //if option, options canvas disable, 
        //if highscore, highscore canvas disable
        currentCanvas.enabled = false;
    }

}
