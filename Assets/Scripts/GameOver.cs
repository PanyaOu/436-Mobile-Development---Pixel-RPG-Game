using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void PlayAgain()
    {
        // Loads the next scene in the build order
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        // Loads the next scene in the build order
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
}
