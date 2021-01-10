using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Instructions;

    // start game
    public void StartGame()
    {
        SceneManager.LoadScene("Scene01");
    }
    
    // close the game
    public void ExitGame()
    {
        Application.Quit();
    }

    // back to main menu
    public void BacktoMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    // Controls UI
    public void InstructionsMenu()
    {
        Instructions.gameObject.SetActive(true);
    }
    
}
