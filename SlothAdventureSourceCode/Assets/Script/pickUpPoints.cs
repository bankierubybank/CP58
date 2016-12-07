using UnityEngine;
using System.Collections;

public class pickUpPoints : MonoBehaviour {

    public int healthToGive;

    private ScoreManager theScoreManager;

    private AudioSource cakeSound;

	// Use this for initialization
	void Start () {
        theScoreManager = FindObjectOfType<ScoreManager>();
        cakeSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
	}
	
    //trigger when player touch cakes
    void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.gameObject.name == "Player")
        {
            theScoreManager.AddHealth(healthToGive);
            gameObject.SetActive(false);

            if (cakeSound.isPlaying)
            {
                cakeSound.Stop();
                cakeSound.Play();
            }
            else
            {
                cakeSound.Play();
            }
        }
    }
}
