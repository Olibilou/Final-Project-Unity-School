using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
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
