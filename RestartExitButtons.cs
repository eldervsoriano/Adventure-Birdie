using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartExitButtons : MonoBehaviour
{
    public Canvas canvas;
    public void RestartButton()
    {

        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}