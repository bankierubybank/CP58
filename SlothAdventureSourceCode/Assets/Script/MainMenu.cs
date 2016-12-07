using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string playGameLavel;
	public void PlayGame()
    {
        Application.LoadLevel(playGameLavel);
    }

    public void HowToPlay()
    {
        Application.LoadLevel(playGameLavel);
    }

    public void Credit()
    {
        Application.LoadLevel(playGameLavel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
