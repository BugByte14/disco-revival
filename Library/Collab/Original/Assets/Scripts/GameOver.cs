using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject enemy;
    public static bool isGameOver;
    public GameObject gameOverUI;
    //private int maxEnemies = 20;
    public HealthBar health;

    void Start()
    {
        gameOverUI.SetActive(false);
    }

    void Update()
    {
        if (health.GetHealth() <= 0)
        {
            Time.timeScale = 0f;
            gameOverUI.SetActive(true);
        }
    }
    public void QuitGame()
    {
        Debug.Log("DIEEEE!!!");
        Application.Quit();
    }
    public void OpenMenu()
    {
        Debug.Log("Main Menu Pressed");
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
