using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject FadeToBlack;

    // this loads the next scene when called 
    public void Start()
    {

    }

    public void PlayGame()
    {
        StartCoroutine(PlayFirstLevel());

    }
    IEnumerator PlayFirstLevel()
    {
        Cursor.visible = false;
        FadeToBlack.SetActive(true);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Play works");// remove when game working 
    }
    // this will quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
