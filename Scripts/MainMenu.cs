using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// loading page, options page, settings, instructions , wuit page in this coding script
/// </summary>
/// 

public class MainMenu : MonoBehaviour
{
    //when player statrs game with play button
  public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    //wehn player presses quit button, the game will exit
    public void QuitGame()
    {
        Debug.Log("quiting");
        Application.Quit();
    }
}
