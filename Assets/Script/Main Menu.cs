using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject menu,credits;
    public string gameSceneName;

    
    public void openCredits()
    {
        menu.SetActive(false);
        credits.SetActive(true);
    }
    public void goBack()
    {
        credits.SetActive(false);
        menu.SetActive(true);
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void playGame()
    {
        menu.SetActive(false);
        SceneManager.LoadScene(gameSceneName);
    }
    
}
