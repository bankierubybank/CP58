using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

    public string mainMenuLevel;

    public GameObject pausemenu;

    public void pauseMenu()
    {
        Time.timeScale = 0f;
        pausemenu.SetActive(true);
    }

    public void ResumeMenu()
    {
        Time.timeScale = 1f;
        pausemenu.SetActive(false);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        pausemenu.SetActive(false);
        FindObjectOfType<GameManager>().reset();
    }

    public void QuitToMainMenu()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(mainMenuLevel);
    }

}
