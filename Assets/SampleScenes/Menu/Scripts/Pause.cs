using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject Player;
  



    // Update is called once per frame
    // if escape key pressed active pause menu
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == false)
            {
                Time.timeScale = 0;
                GameIsPaused = true;
                Cursor.visible = true;
                pauseMenuUI.SetActive(true);
                Player.GetComponent<FirstPersonController>().enabled = false;
                Cursor.lockState = CursorLockMode.Confined;
                AudioListener.volume = 0f;
            }
            else
            {
                Time.timeScale = 1;
                GameIsPaused = false;
                Cursor.visible = false;
                pauseMenuUI.SetActive(false);
                Player.GetComponent<FirstPersonController>().enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                AudioListener.volume = 1f;
            }
        }
    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
        Cursor.visible = false;
        Player.GetComponent<FirstPersonController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        AudioListener.volume = 1f;
    }
    // load onenMenu scene
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    // exit game 
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
