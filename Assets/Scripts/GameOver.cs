using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject enemy;
    public static bool isGameOver;
    public GameObject gameOverUI;
    private int maxEnemies = 20;
    public GameObject healthUI;


    void Start()
    {
        gameOverUI.SetActive(false);
    }

    void Update()
    {
        int enemyAmount = GameObject.FindGameObjectsWithTag("Bad Guy").Length;
        if (enemyAmount >= maxEnemies)
        {
            Debug.Log("death");
            Time.timeScale = 0f;
            gameOverUI.SetActive(true);
            healthUI.SetActive(false);
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
        Time.timeScale = 1f;
        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
