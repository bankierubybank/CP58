using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    //ground generator
    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    //player
    public PlayerController thePlayer;
    private Vector3 playerStartPoint;

    //ground destroyer
    private PlatformDestroyer[] platformList;

    //score
    private ScoreManager theScoreManager;

    //death menu
    public DeathMenu theDeathsceen;
    
    // Use this for initialization
    void Start () {

        //ground generator start point
        platformStartPoint = platformGenerator.position;

        //player start point
        playerStartPoint = thePlayer.transform.position;

        //score
        theScoreManager = FindObjectOfType<ScoreManager>();
	
	}

    //initialize when player died
    public void RestartGame()
    {
        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);
        theDeathsceen.gameObject.SetActive(true);
    }

    //reset game
    public void reset()
    {
        theDeathsceen.gameObject.SetActive(false);
        platformList = FindObjectsOfType<PlatformDestroyer>();
        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false);
        }
        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }
}
