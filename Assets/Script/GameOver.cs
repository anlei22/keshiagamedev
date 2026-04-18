using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Update()
    {
        // Check if player is destroyed (null) and game over not yet triggered
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    // Called by UI Button to restart the current scene
            public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Called by UI Button to go to main menu scene (index 0)
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
    