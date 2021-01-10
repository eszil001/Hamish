using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // The pauseMenu UI
    public GameObject pauseUI;
    

    // When pressing escape will open the pauseUI
   [SerializeField] private KeyCode PauseKey = KeyCode.Escape;


    // Start is called before the first frame update
    void Start()
    {
       // setting it first to false just in case
       pauseUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(PauseKey))
        {
            // pause UI will appear and also freeze the time (0)
            pauseUI.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }
    // using it for a button in the UI
    public void Resume()
    {
        // pause UI will close and the time will go back to normal (1)
        pauseUI.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartLVL()
    {
        // using scenemanager, to restart the current level.
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        // since to get to this menu, I have to pause, therefore I have to start the time back again:
        Time.timeScale = 1f;
    }
}
