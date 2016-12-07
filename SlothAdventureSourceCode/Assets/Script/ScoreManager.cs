using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour {

    public Text ScoreText;
    public Text HighScoreText;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;
    public bool scoreIncreasing;

    private PlayerController thePlayerController;

	// Use this for initialization
	void Start () {

        if(PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("HighScore");
        }

        thePlayerController = FindObjectOfType<PlayerController>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if(scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", highScoreCount);
        }

        ScoreText.text = "Score: " + Mathf.Round(scoreCount);
        HighScoreText.text = "High Score: " +Mathf.Round(highScoreCount);
	}

    public void AddHealth(int pointsToAdd)
    {
        thePlayerController.currentHealth += pointsToAdd;
    }
}
