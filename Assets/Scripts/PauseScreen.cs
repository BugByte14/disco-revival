using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    public static bool GamePaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    void Resume()
    {
        Time.timeScale = 1f;
        GamePaused = false;
    }
    void Pause()
    {
        Time.timeScale = 0f;
        GamePaused = true;
    }
}
