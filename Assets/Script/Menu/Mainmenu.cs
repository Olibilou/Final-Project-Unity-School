using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void StartGame()
    {
        AllowSkipLevel.skipLevel = 2;
        CurrentLevel.timer = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        AllowSkipLevel.skipLevel = 2;
        CurrentLevel.timer = 0f;
        SceneManager.LoadScene(1);
    }

    public void returnMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void restartlastlevel()
    {
        SceneManager.LoadScene(CurrentLevel.CurrentLevels);
    }

}
